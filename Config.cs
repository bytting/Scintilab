/** @file Config.cs 
 * Configurasjon for Scintilab  
 */ 
using System;
using System.IO;
using System.Collections.Generic;

namespace Scintilab
{
    /**
     * Klasse for Scintilab configurasjon.
     * Denne klassen inneholder kataloger og filnavn som brukes av Scintilab.
     */
    public class Config
    {
        /** Arbeidskatalogen til Scintilab. Defineres som miljøvariabelen SCINTILAB */
        public static string ScintilabDir;
        /** Katalog for .CNF bakgrunnsfiler */
        public static string BkgDir;
        /** Katalog for .NLB biblioteksfiler */
        public static string LibDir;
        /** Katalog for .CAL kalibrasjonsfiler */
        public static string CalDir;
        /** Katalog for .TPL rapport filer */
        public static string TemplateDir;
        /** Katalog for arkivet. (.CNF, .PAR og .RPT filer) */
        public static string ArchiveDir;
        /** Katalog for pågående jobber */
        public static string JobDir;
        /** Katalog for midlertidig lagring av filer */
        public static string TempDir;
        /** Katalog for .QAF "Quality Assurance" filer */
        public static string QADir;
        /** Instalasjonskatalogen til Scintilab */
        public static string ExeDir;
        /** Katalogbane til Template katalogen under instalasjonskatalogen */
        public static string TemplDir;
        /** Filbane til system konfigurasjon SYSTEM.XML */
        public static string SysFile;
        /** Filbane til detektor-definisjoner DETECTORS.XML */
        public static string DetFile;
        /** Filbane til geometri-definisjoner BEAKERS.XML */
        public static string BeakerFile;
        /** Filbane til QA geometri-definisjoner QABEAKERS.XML */
        public static string QABeakerFile;
        /** Filbane til template for QA bakgrunn */
        public static string DefaultBkgQAFFile;
        public static string DefaultRefQAFFile;

        /* Filbane til logg-fil */
        public static string LogFile;

        public static void LogMessage(string msg)
        {
            StreamWriter sw = new StreamWriter(LogFile, true);
            sw.WriteLine(DateTime.Now.ToString() + " - " + Username + " - " + msg);
            sw.Close();
        }

        /** AD-Brukernavn for Scintilab bruker */
        public static string Username;
    }
}