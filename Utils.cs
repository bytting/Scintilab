/** @file Utils.cs 
 * Hjelpefunksjoner og klasser for Scintilab  
 */ 
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;

namespace Scintilab
{
    /**
     * Klasse for media avspilling.
     * Denne klassen inneholder funksjoner for avspilling av .WAV filer.
     */
    public class Media
    {
        /** Objekt for avspilling av media */
        static System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        /**     
         * Avspill angitt .WAV fil.
         * 
         * @param      filename Navn på .WAV fil som skal avspilles
         */
        public static void PlayWav(string filename)
        {
            // Sett spillerens filbane for .WAV fil som skal avspilles
            player.SoundLocation = Config.ExeDir + "Resources" + Path.DirectorySeparatorChar + filename;

            // Avspill filen hvis den finnes
            if(File.Exists(player.SoundLocation))
                player.Play();
        }
    }

    /**
     * Klasse for generelle hjelpefunksjoner
     * Denne klassen inneholder diverse hjelpefunksjoner
     */
    public class Utils
    {
        /**     
         * Avspill angitt .WAV fil.
         * 
         * @param   d Detektor som skal sjekkes for aktive jobber
         * 
         * @return  Sant hvis detektoren har en aktiv jobb, usant ellers
         */
        public static bool HasJob(Detector d)
        {
            // Opprett liste over filbaner til .BAT filer i jobb katalogen
            string[] batFiles = Directory.GetFiles(Config.JobDir, "*.BAT");

            foreach (string file in batFiles)
            {
                // Opprett variabel med kun filnavnet (uten ending) fra filbanen
                string fn = Path.GetFileNameWithoutExtension(file);

                // Hvis filnavnet tilsvarer navnet på detektoren, har detektoren en aktiv jobb
                if (d.Name.ToUpper() == fn.ToUpper())
                    return true; // Detektoren har en aktiv jobb
            }
            return false; // Detektoren har ikke en aktiv jobb
        }

        /**     
         * Sjekk om angitt detektor er klar for bruk
         * 
         * @param   d Detektor som skal sjekkes
         * @param   lbl Label som skal vise status meldinger
         * 
         * @return  Sant hvis detektoren er klar for bruk, usant ellers
         */
        public static bool IsDetectorReady(Detector d, ref ToolStripStatusLabel lbl)
        {
            // Kjør programmet "mcainfo.exe" for å få tak i status på detektoren
            string cout; // Ta imot standard output fra mcainfo.exe med denne
            // Kjør programmet mcainfo.exe
            if (!Utils.RunCommand(Config.ExeDir + "mcainfo.exe", d.Name, out cout, true))
            {
                // Noe gikk galt, vis feilmelding og avslutt
                MessageBox.Show("mcainfo.exe feilet");
                return false;
            }

            char[] itemSeps = { ',' }; // Seperatør for parametere gitt av mcainfo.exe
            char[] tokenSeps = { ':' }; // Seperatør for for å splitte navn/verdi på parametere gitt av mcainfo.exe
            string[] items = cout.Split(itemSeps, StringSplitOptions.RemoveEmptyEntries); // Opprett liste over parametere
            string[] exists = items[1].Split(tokenSeps, StringSplitOptions.RemoveEmptyEntries); // Hent verdi for parameter 1
            string[] voltage = items[2].Split(tokenSeps, StringSplitOptions.RemoveEmptyEntries); // Hent verdi for parameter 2
            string[] busy = items[3].Split(tokenSeps, StringSplitOptions.RemoveEmptyEntries); // Hent verdi for parameter 3
            string[] chans = items[4].Split(tokenSeps, StringSplitOptions.RemoveEmptyEntries); // Hent verdi for parameter 4

            // Hvis verdien til parameter 1 (exists) ikke er "YES", så er ikke detektoren definert i Genie2k
            if (exists[1].Trim().ToUpper() != "YES")
            {
                // Vis feilmelding og avslutt
                MessageBox.Show("Detektor " + d.Name + " er ikke tilkoblet");
                return false;
            }

            // Hvis verdien til parameter 3 (busy) ikke er "NO", så er detektoren opptatt
            if (busy[1].Trim().ToUpper() != "NO")
            {
                // Vis feilmelding og avslutt
                MessageBox.Show("Detektor " + d.Name + " er opptatt");
                return false;
            }

            // Hvis verdien til parameter 2 (voltage) ikke er "ON", så mangler detektoren høyspenning
            if (voltage[1].Trim().ToUpper() != "ON")
            {
                // Si fra til bruker at høyspenning settes på
                lbl.Text = "Setter på høyspenning for detektor " + d.Name + "...";
                Application.DoEvents(); // Tøm hendelseskøen slik at lbl blir oppdatert umiddelbart
                string output; // Ta imot standard output
                // Kjør programmet HVCNTL for å seete på høyspenning for detektoren
                Utils.RunCommand("HVCNTL", "det:" + d.Name + " /ON", out output, true);                
            }

            // Sett detektorens max antall kanaler like parameter 4 (chans) fra mcainfo.exe
            d.MaxChannels = Convert.ToInt32(chans[1]);

            return true; // Detektoren er klar til bruk
        }

        /**     
         * Sjekk at angitt Genie2k katalog er gyldig
         * 
         * @param   sp System parametere for Scintilab
         * @param   newGeniePath Katalogbane som skal sjekkes
         * 
         * @return  Sant hvis katalogbanen er en gyldig Genie2k katalog, usant ellers
         */
        public static bool ValidateGeniePath(SystemParameters sp, string newGeniePath)
        {
            // Hvis angitt katalogbane er gyldig, avslutt med suksess status
            if (!String.IsNullOrEmpty(newGeniePath)
                && Directory.Exists(newGeniePath)
                && Directory.Exists(newGeniePath + Path.DirectorySeparatorChar + "EXEFILES"))
                return true;

            // Angitt katalogbane var ugyldig eller ikke funnet, be brukeren velge en Genie2k katalog
            FolderBrowserDialog bd = new FolderBrowserDialog();
            bool done = false;
            bd.Description = "Velg GENIE2K katalog";
            bd.SelectedPath = Path.GetPathRoot(Environment.SystemDirectory);

            // Fortsett til brukeren har angitt en gyldig Genie2k katalog eller trykket "cancel"
            while (!done)
            {
                if (bd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    break;
                newGeniePath = bd.SelectedPath;
                if (String.IsNullOrEmpty(newGeniePath)
                    || !Directory.Exists(newGeniePath)
                    || !Directory.Exists(newGeniePath + Path.DirectorySeparatorChar + "EXEFILES")
                    || !File.Exists(newGeniePath + Path.DirectorySeparatorChar + "EXEFILES" + Path.DirectorySeparatorChar + "MVCG.EXE"))
                {
                    // Vis feilmelding
                    MessageBox.Show("Katalogen " + newGeniePath + " ser ikke ut til å være gyldig. Prøv igjen", "Feil");
                }
                else
                {
                    // Brukeren har valgt en gyldig Genie2k katalog. Lagre denne og avslutt løkken
                    sp.GenieDirectory = newGeniePath; // Sett Genie2k katalogen i systemparameterene
                    SerializeSysPar(sp); // Lagre systemparameterene tilbake til fil
                    done = true; // Avslutt løkke
                }
            }

            return done;
        }

        /**     
         * Kjør et eksternt program
         * 
         * @param   cmd Filbane til kjørbart program
         * @param   args Parametere for kjørbart program
         * @param   output Lagring av programmets standard output
         * @param   waitForExit Angi om funksjonen skal blokkere til eksternt program har avsluttet
         * 
         * @return  Sant hvis kjøring av eksternt program var vellykket, usant ellers
         */
        public static bool RunCommand(string cmd, string args, out string output, bool waitForExit)
        {
            // Opprett og fyll inn datastruktur for ny prosess
            Process p = new Process();
            p.StartInfo.FileName = cmd;
            p.StartInfo.Arguments = args;
            p.StartInfo.WorkingDirectory = Config.JobDir;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = waitForExit ? true : false;

            // Start eksternt program
            p.Start();
            output = "";
            if(waitForExit)
            {
                // Ta imot standard output
                output = p.StandardOutput.ReadToEnd();
                // Vent til programmet avslutter
                p.WaitForExit();
                // Returner exitverdien til programmet
                return p.ExitCode == 0;
            }
            return true;
        }

        /**     
         * Lagre detektor definisjoner til fil
         * 
         * @param   detectors Liste med detektor datastrukturer                  
         */
        public static void SerializeDetectors(List<Detector> detectors)
        {
            // Opprett object for serialisering til fil
            StreamWriter sw = new StreamWriter(Config.DetFile);
            // Opprett object for xml serialisering av detektor listen
            XmlSerializer x = new XmlSerializer(detectors.GetType());
            x.Serialize(sw, detectors); // Serialiser listen til fil
            sw.Close(); // Lukk serialiseringsobjektet
        }

        /**     
         * Lagre geometri definisjoner til fil
         * 
         * @param   beakers Liste med geometri datastrukturer                  
         */
        public static void SerializeBeakers(List<Beaker> beakers)
        {
            StreamWriter sw = new StreamWriter(Config.BeakerFile);
            XmlSerializer x = new XmlSerializer(beakers.GetType());
            x.Serialize(sw, beakers);
            sw.Close();
        }

        /**     
         * Lagre QA-geometri definisjoner til fil
         * 
         * @param   qabeakers Liste med QA-geometri datastrukturer                  
         */
        public static void SerializeQABeakers(List<QABeaker> qabeakers)
        {
            StreamWriter sw = new StreamWriter(Config.QABeakerFile);
            XmlSerializer x = new XmlSerializer(qabeakers.GetType());
            x.Serialize(sw, qabeakers);
            sw.Close();
        }

        /**     
         * Lagre systemparametere til fil
         * 
         * @param   sysPar datastruktur med systemparametere
         */
        public static void SerializeSysPar(SystemParameters sysPar)
        {
            if (File.Exists(Config.SysFile))
            {
                StreamWriter sw = new StreamWriter(Config.SysFile);
                XmlSerializer x = new XmlSerializer(sysPar.GetType());
                x.Serialize(sw, sysPar);
                sw.Close();
            }
        }

        /**     
         * Last inn systemparametere fra fil
         * 
         * @return   Datastruktur med innlastede systemparametere
         */
        public static SystemParameters DeserializeSysPar()
        {
            SystemParameters sysPar = new SystemParameters();
            StreamReader sr = new StreamReader(Config.SysFile);
            XmlSerializer x = new XmlSerializer(sysPar.GetType());
            sysPar = x.Deserialize(sr) as SystemParameters;
            sr.Close();
            return sysPar;
        }

        /**     
         * Last inn detektor definisjoner fra fil
         * 
         * @return   Liste med innlastede detektor datastrukturer
         */
        public static List<Detector> DeserializeDetectors()
        {
            List<Detector> detectors = new List<Detector>();
            StreamReader sr = new StreamReader(Config.DetFile);
            XmlSerializer x = new XmlSerializer(detectors.GetType());
            detectors = x.Deserialize(sr) as List<Detector>;
            sr.Close();
            return detectors;
        }

        /**     
         * Last inn geometri definisjoner fra fil
         * 
         * @return   Liste med innlastede geometri datastrukturer
         */
        public static List<Beaker> DeserializeBeakers()
        {
            List<Beaker> beakers = new List<Beaker>();
            StreamReader sr = new StreamReader(Config.BeakerFile);
            XmlSerializer x = new XmlSerializer(beakers.GetType());
            beakers = x.Deserialize(sr) as List<Beaker>;
            sr.Close();
            return beakers;
        }

        /**     
         * Last inn QA-geometri definisjoner fra fil
         * 
         * @return   Liste med innlastede QA-geometri datastrukturer
         */
        public static List<QABeaker> DeserializeQABeakers()
        {
            List<QABeaker> beakers = new List<QABeaker>();
            StreamReader sr = new StreamReader(Config.QABeakerFile);
            XmlSerializer x = new XmlSerializer(beakers.GetType());
            beakers = x.Deserialize(sr) as List<QABeaker>;
            sr.Close();
            return beakers;
        }

        /**     
         * Lagre jobb-parametere til fil
         * 
         * @param   jp Datastruktur med jobb parametere
         * @param   filename Filbane til .XML fil som skal lagres
         */
        public static void SerializeJobParams(JobParams jp, string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            XmlSerializer x = new XmlSerializer(jp.GetType());
            x.Serialize(sw, jp);
            sw.Close();
        }

        /**     
         * Last inn jobb-parametere fra fil
         * 
         * @return   Datastruktur med jobb-parametere
         */
        public static JobParams DeserializeJobParams(string filename)
        {
            JobParams jp = new JobParams();
            StreamReader sr = new StreamReader(filename);
            XmlSerializer x = new XmlSerializer(jp.GetType());
            jp = x.Deserialize(sr) as JobParams;
            sr.Close();
            return jp;
        }

        /**     
         * Legg til katalogseparator på katalogbane hvis den ikke finnes allerede
         * 
         * @param   path Katalogbane som skal utvides
         */
        public static void FixDirectorySeparator(ref string path)
        {
            if (path.Length > 0) // Skip hvis katalogbanen er tom
            {
                if (path[path.Length - 1] != Path.DirectorySeparatorChar) // Hvis siste karakter ikke er katalog separator...
                    path += Path.DirectorySeparatorChar; // Legg til katalog separator
            }
        }

        /**     
         * Konverter tekst til desimaltall (desimalseparator uavhengig)
         * 
         * @param   text Tekst som skal konverteres
         */
        public static double ConvertToDouble(string text)
        {
            // Erstatt '.' med systemets desimalseparator
            text = text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            // Erstatt ',' med systemets desimalseparator
            text = text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            return Convert.ToDouble(text); // Konverter og returner desimaltall
        }

        /**     
         * Sjekk at et enhetsnavn kun inneholder gyldige karakterer
         * 
         * @param   name navnet som skal sjekkes
         * 
         * @return  Sant hvis navnet er gyldig, usant ellers
         */
        public static bool ValidName(string name)
        {
            // Tom streng er ugyldig
            if (String.IsNullOrEmpty(name))
                return false;

            // Sjekk at hver karakter i navnet er enten bokstav, tall eller '-'
            foreach (char ch in name)
                if (!Char.IsLetterOrDigit(ch) && ch != '-')
                    return false; // Ugyldig tegn funnet
            return true;
        }
    }
}