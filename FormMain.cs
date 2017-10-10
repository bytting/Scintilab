/*	
	Scintilab - GUI Shell for running scintillator detectors
    Copyright (C) 2016  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag Robole,

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Threading;

namespace Scintilab
{
    /** @brief Hovedklasse for Scintilab*/

    public partial class FormMain : Form
    {
        /** Datastruktur med systemparametere */
        private SystemParameters SysPar = null;
        /** Liste med detektor datastrukturer */
        public List<Detector> Detectors = null;
        /** Liste med geometri datastrukturer */
        private List<Beaker> Beakers = null;
        /** Liste med QA-geometri datastrukturer */
        private List<QABeaker> QABeakers = null;
        /** Datastruktur med brukerens valgte parametere */
        private SelectionInfo SelInfo = new SelectionInfo();
        /** Objekt for filsystemhendelser i jobb katalogen */
        FileSystemWatcher watcher = new FileSystemWatcher();
        /** Angir om det er nødvendig med en oppdatering av jobber */
        bool updateJobs = false;
        /** Angir om analyse er en reanalysering */
        bool isReanal = false;

        /** 
         * Konstruktør
         */
        public FormMain()
        {
            InitializeComponent();
        }

        /** 
         * Hent detektor basert på navn
         * 
         * @param      name Navn på detektor som skal hentes
         * 
         * @return     Detektor, eller null hvis ikke funnet
         */
        private Detector getDetectorByName(string name)
        {
            // Sjekk om navn på detektor finnes i lista over detektorer

            // Mellomlager for funnet detektor
            Detector d = null;
            for (int i = 0; i < Detectors.Count; i++)
            {
                if (Detectors[i].Name.ToUpper() == name.ToUpper())
                {
                    // Detektor funnet, mellomlagre detektor og avslutt løkke
                    d = Detectors[i];
                    break;
                }
            }
            return d;
        }

        /** 
         * Hent beger basert på navn
         * 
         * @param      name Navn på beger
         * 
         * @return     Beger, eller null hvis ikke funnet
         */
        private Beaker getBeakerByName(string name)
        {
            // Sjekk om navn på beger finnes i lista over begere

            // Mellomlager for funnet beger
            Beaker b = null;
            for (int i = 0; i < Beakers.Count; i++)
            {
                if (Beakers[i].Name.ToUpper() == name.ToUpper())
                {
                    // Beger funnet, mellomlagre beger og avslutt løkke
                    b = Beakers[i];
                    break;
                }
            }
            return b;
        }

        /** 
         * Hent QA-beger basert på navn
         * 
         * @param      name Navn på QA-beger
         * 
         * @return     QA-beger, eller null hvis ikke funnet
         */
        private QABeaker getQABeakerByName(string name)
        {
            // Sjekk om navn på QA-beger finnes i lista over QA-begere

            // Mellomlager for funnet QA-beger
            QABeaker b = null;
            for (int i = 0; i < QABeakers.Count; i++)
            {
                if (QABeakers[i].Name.ToUpper() == name.ToUpper())
                {
                    // QA-beger funnet, mellomlagre QA-beger og avslutt løkke
                    b = QABeakers[i];
                    break;
                }
            }
            return b;
        }

        /** 
         * Tøm alle felter under administrasjon av detektorer
         */
        void clearAdmDetectors()
        {
            tbAdmDetSearchRegionFrom.Text = "";
            tbAdmDetSearchRegionTo.Text = "";
            tbAdmDetTolerance.Text = "";
            tbAdmDetSignThresh.Text = "";
            tbAdmDetPeakAreaRegionFrom.Text = "";
            tbAdmDetPeakAreaRegionTo.Text = "";
            tbAdmDetContinuum.Text = "";
            cboxAdmDetContinuumFunc.Text = "";
            cbAdmDetCriticalLevel.Checked = false;
            cbAdmDetFitSinglets.Checked = false;
            cbAdmDetDisplayROIs.Checked = false;
            cbAdmDetUseFixedTailParam.Checked = false;
            cbAdmDetRejectZeroAreaPeaks.Checked = false;
            cbAdmDetUseFixedFWHM.Checked = false;
            cboxAdmDetEffCalType.Text = "";
            tbAdmDetMaxFHWMBetPeaks.Text = "";
            tbAdmDetMaxFHWMLeftLim.Text = "";
            tbAdmDetMaxFHWMRightLim.Text = "";
            tbAdmDetBkgSub.Text = "";
            tbAdmDetNIDLib.Text = "";
            tbAdmDetNIDConfThresh.Text = "";
            tbAdmDetMDAConfFac.Text = "";
            cbAdmDetInhibitATDCorr.Checked = false;
            cbAdmDetUseStoredLib.Checked = false;
            cbAdmDetPerfMDATest.Checked = false;

            cboxAdmDetPresetArea.Text = "";
            tbAdmDetPresetAreaValue.Text = "";
            tbAdmDetPresetAreaChanFrom.Text = "";
            tbAdmDetPresetAreaChanTo.Text = "";
            cboxAdmDetPresetTime.Text = "";
            tbAdmDetPresetTimeValue.Text = "";
            cboxAdmDetPresetTimeUnit.Text = "";
            tbAdmDetRandErr.Text = "";
            tbAdmDetSysErr.Text = "";
            gridAdmDetGeomCalQA.Rows.Clear();
        }

        /** 
         * Tøm alle felter under administrasjon av begere
         */
        void clearAdmBeakers()
        {
            tbAdmGeomManufacturer.Text = "";
            cbAdmGeomInUse.Checked = false;
        }

        /** 
         * Tøm alle felter under administrasjon av QA-begere
         */
        void clearAdmQABeakers()
        {
            cbAdmQAInUse.Checked = false;
            cboxAdmQABeaker.Text = "";
            dtAdmQARefDate.Value = DateTime.Now;
            dtAdmQARefTime.Value = DateTime.Now;
            tbAdmQASampType.Text = "";
            tbAdmQASampQuant.Text = "";
            cboxAdmQASampUnit.Text = "";
            tbAdmQASampUnc.Text = "";
        }

        /** 
         * Tøm alle felter under prøveinfo
         */
        void clearSampParams()
        {
            tbSampOrder.Text = "";
            tbSampDesc.Text = "";
            tbSampID.Text = "";
            tbSampType.Text = "";
            cboxSampGeom.Text = "";
            tbSampQuant.Text = "";
            cboxSampQuantUnit.Text = "";
            tbSampQuantUnc.Text = "";
            tbSampRef.Text = "";
            tbSampCollector.Text = "";
            tbSampComment.Text = "";
            dtSampBuildNoneDate.Value = DateTime.Now;
            dtSampBuildNoneTime.Value = DateTime.Now;
            dtSampBuildIrradDateFrom.Value = DateTime.Now;
            dtSampBuildIrradTimeFrom.Value = DateTime.Now;
            dtSampBuildIrradDateTo.Value = DateTime.Now;
            dtSampBuildIrradTimeTo.Value = DateTime.Now;
            dtSampBuildDepDateFrom.Value = DateTime.Now;
            dtSampBuildDepTimeFrom.Value = DateTime.Now;
            dtSampBuildDepDateTo.Value = DateTime.Now;
            dtSampBuildDepTimeTo.Value = DateTime.Now;

            cboxSampAdvCal.Text = "";
            tbSampAdvRandErr.Text = "";
            tbSampAdvSystErr.Text = "";
            cboxSampAdvPreArea.Text = "";
            tbSampAdvPreAreaValue.Text = "";
            tbSampAdvPreAreaChanFrom.Text = "";
            tbSampAdvPreAreaChanTo.Text = "";
            cboxSampAdvPreTime.Text = "";
            tbSampAdvPreTimeValue.Text = "";
            cboxSampAdvPreTimeUnit.Text = "";

            tbSampAnalTolerance.Text = "";
            tbSampAnalSigThresh.Text = "";
            tbSampAnalContinuum.Text = "";
            cboxSampAnalContinuumFunc.Text = "";
            cbSampAnalCritLev.Checked = false;
            cbSampAnalFitSinglets.Checked = false;
            cbSampAnalDispRois.Checked = false;
            cbSampAnalUseFixed.Checked = false;
            cbSampAnalRejectZero.Checked = false;
            cbSampAnalFixedFWHM.Checked = false;
            cboxSampAnalEffCal.Text = "";
            tbSampAnalMaxFWHMBetween.Text = "";
            tbSampAnalMaxFWHMLeft.Text = "";
            tbSampAnalMaxFWHMRight.Text = "";
            tbSampAnalBkgSub.Text = "";
            tbSampAnalNIDLib.Text = "";
            tbSampAnalNIDConfThresh.Text = "";
            tbSampAnalMDAConfFac.Text = "";
            cbSampAnalInhibitATD.Checked = false;
            cbSampAnalUseStoredLib.Checked = false;
            cbSampAnalPerformMDA.Checked = false;

            tabsSamples.SelectedTab = tabSamplesParams;
        }

        /** 
         * Fyll inn gyldige begere under prøveinfo for valg detektor
         * 
         * @param   detName Navn på valgt detektor
         */
        private void populateSampGeom(string detName)
        {
            Detector d = getDetectorByName(detName); // Hent datastruktur for detektor
            cboxSampGeom.Items.Clear(); // Tøm dropdown for geometrier
            // Legg til alle detektorens geometrier i dropdown for geometrier
            for (int i = 0; i < d.BeakerInfoList.Count; i++)
                cboxSampGeom.Items.Add(d.BeakerInfoList[i].BeakerName);
        }

        /** 
         * Fyll inn gyldige begere under prøveinfo for valg detektor (kun de som har QA-beger)
         * 
         * @param   detName Navn på valgt detektor
         */
        private void populateSampGeomWithQA(string detName)
        {
            Detector d = getDetectorByName(detName); // Hent datastruktur for detektor
            cboxSampGeom.Items.Clear(); // Tøm dropdown for geometrier
            for (int i = 0; i < d.BeakerInfoList.Count; i++)
                // Legg til geometri hvis den har QA-geometri definert
                if (!String.IsNullOrEmpty(d.BeakerInfoList[i].QAName))
                    cboxSampGeom.Items.Add(d.BeakerInfoList[i].BeakerName);
        }

        /** 
         * Fyll inn gyldige .CAL filer for valg detektor og beger
         * 
         * @param   d Valgt detektor
         * @param   beakerName Navn på valgt beger
         */
        private void addCalFilesToSamp(Detector d, string beakerName)
        {
            cboxSampAdvCal.Items.Clear(); // Tøm dropdown for calbreringsfiler
            // Opprett filnavnfilter for kalibreringsfiler
            string filter = d.Name + beakerName + "*.CAL";
            // Opprett liste over filbaner til kalibreringsfiler som tilfredstiller filteret
            string[] files = Directory.GetFiles(Config.CalDir, filter);
            // Legg til kalibreringsfilene i dropdown (kun filnavnet)
            foreach (string fn in files)
                cboxSampAdvCal.Items.Add(Path.GetFileName(fn));

            // Sett aktivt beger i dropdown hvis det finnes i detektor definisjonen
            for (int i = 0; i < d.BeakerInfoList.Count; i++)
                if (d.BeakerInfoList[i].BeakerName == beakerName)
                    cboxSampAdvCal.Text = Path.GetFileName(d.BeakerInfoList[i].CalibrationFile);
        }

        /** 
         * Hendelse for program avslutt
         */
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            // Avslutt Scintilab
            Close();
        }

        /** 
         * Oppdater detektor lister
         */
        private void UpdateDetectorLists()
        {
            lbAdmDetList.Items.Clear(); // Tøm detektorliste på admin-sidene
            lvDetectors.Items.Clear(); // Tøm detektorliste på meny-sidene
            // Fyll inn detektorlistene på nytt, basert på lista med definerte detektorstrukturer
            for (int i = 0; i < Detectors.Count(); i++)
            {
                lbAdmDetList.Items.Add(Detectors[i].Name);
                if (Detectors[i].InUse) // Legg til i menylista kun hvis den er i bruk
                    lvDetectors.Items.Add(Detectors[i].Name, 0);
            }
        }

        /** 
         * Hendelse for programstart
         */
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                tabs.Appearance = TabAppearance.FlatButtons;
                tabs.ItemSize = new Size(0, 1);
                tabs.SizeMode = TabSizeMode.Fixed;
                tabs.SelectedTab = pageMenu;
                
                Width = 800; // Bredde på vindu
                Height = 550; // Høyde på vindu
                lblToolsInterface.Text = tabs.SelectedTab.Text; // Vis navnet på valgt fane i toppmenyen
                lblToolsDetector.Text = ""; // Tøm navn på valgt detektor i toppmenyen                                

                // Hent verdien til miljøvariabelen "SCINTILAB"
                string envDir = Environment.GetEnvironmentVariable("SCINTILAB");
                if (envDir == null)
                {
                    // Miljøvariabelen "SCINTILAB" ble ikke funnet, vis feilmelding og avslutt Scintilab
                    MessageBox.Show("Miljøvariabelen SCINTILAB ble ikke funnet. Avslutter");
                    Close();
                }

                // Sett opp alle konfigurasjonsparametere
                Config.ScintilabDir = envDir + Path.DirectorySeparatorChar;
                if (!Directory.Exists(Config.ScintilabDir))
                    Directory.CreateDirectory(Config.ScintilabDir);
                Config.BkgDir = Config.ScintilabDir + "BACKGROUND\\";
                if (!Directory.Exists(Config.BkgDir))
                    Directory.CreateDirectory(Config.BkgDir);
                Config.LibDir = Config.ScintilabDir + "LIBRARY\\";
                if (!Directory.Exists(Config.LibDir))
                    Directory.CreateDirectory(Config.LibDir);
                Config.CalDir = Config.ScintilabDir + "CALIBRATION\\";
                if (!Directory.Exists(Config.CalDir))
                    Directory.CreateDirectory(Config.CalDir);
                Config.TemplateDir = Config.ScintilabDir + "TEMPLATE\\";
                if (!Directory.Exists(Config.TemplateDir))
                    Directory.CreateDirectory(Config.TemplateDir);
                Config.ArchiveDir = Config.ScintilabDir + "ARCHIVE\\";
                if (!Directory.Exists(Config.ArchiveDir))
                    Directory.CreateDirectory(Config.ArchiveDir);
                Config.JobDir = Config.ScintilabDir + "JOBS\\";
                if (!Directory.Exists(Config.JobDir))
                    Directory.CreateDirectory(Config.JobDir);
                Config.TempDir = Config.ScintilabDir + "TEMP\\";
                if (!Directory.Exists(Config.TempDir))
                    Directory.CreateDirectory(Config.TempDir);
                Config.QADir = Config.ScintilabDir + "QA\\";
                if (!Directory.Exists(Config.QADir))
                    Directory.CreateDirectory(Config.QADir);

                // Hent katalogbane for Scintilab.exe
                Config.ExeDir = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory + "\\";      
                Config.TemplDir = Config.ExeDir + "Templates" + Path.DirectorySeparatorChar; 

                Config.SysFile = Config.ScintilabDir + "SYSTEM.XML";
                if (!File.Exists(Config.SysFile))
                    File.WriteAllText(Config.SysFile, Properties.Resources.TEMPLATE_SYSTEM);
                Config.DetFile = Config.ScintilabDir + "DETECTORS.XML";
                if (!File.Exists(Config.DetFile))
                    File.WriteAllText(Config.DetFile, Properties.Resources.TEMPLATE_DETECTORS);
                Config.BeakerFile = Config.ScintilabDir + "BEAKERS.XML";
                if (!File.Exists(Config.BeakerFile))
                    File.WriteAllText(Config.BeakerFile, Properties.Resources.TEMPLATE_BEAKERS);
                Config.QABeakerFile = Config.ScintilabDir + "QABEAKERS.XML";
                if (!File.Exists(Config.QABeakerFile))
                    File.WriteAllText(Config.QABeakerFile, Properties.Resources.TEMPLATE_QABEAKERS);
                Config.DefaultBkgQAFFile = Config.ScintilabDir + "DEFAULT-BKG.QAF";
                if (!File.Exists(Config.DefaultBkgQAFFile))
                    File.WriteAllBytes(Config.DefaultBkgQAFFile, Properties.Resources.TEMPLATE_DEFAULT_BKG);                    

                Config.LogFile = Config.ScintilabDir + "runlog.txt";

                // Opprett REPORT.TPL basert på TEMPLATE-REPORT.TPL hvis den ikke finnes fra før under arbeidskatalogen
                if (!File.Exists(Config.TemplateDir + "REPORT.TPL"))
                    File.WriteAllBytes(Config.TemplateDir + "REPORT.TPL", Properties.Resources.TEMPLATE_REPORT);

                // Opprett LIBRARY.NLB basert på TEMPLATE-LIBRARY.NLB hvis den ikke finnes fra før under arbeidskatalogen
                if (!File.Exists(Config.LibDir + "LIBRARY.NLB"))
                    File.WriteAllBytes(Config.LibDir + "LIBRARY.NLB", Properties.Resources.TEMPLATE_LIBRARY);                    

                // Last inn systemparametere fra fil
                SysPar = Utils.DeserializeSysPar();

                // Opprett og vis vindu for innlogging
                FormLogin form = new FormLogin(SysPar.UseActiveDirectory);
                form.ShowDialog();
                if (form.DialogResult != System.Windows.Forms.DialogResult.OK)
                    // Avslutt Scintilab hvis innlogging avbrytes
                    Close();

                SysPar.UseActiveDirectory = form.UseActiveDirectory;

                Config.Username = form.Username; // Lagre brukernavn i konfigurasjon
                lblStatusUsername.Text = Config.Username; // Sett brukernavn i toppmenyen

                // Be brukeren velge Genie2k katalog hvis systemparameter ikke har en gyldig en fra før
                if (!Utils.ValidateGeniePath(SysPar, SysPar.GenieDirectory))
                    Close();

                // Sjekk at valgt Genie2k katalog ser fornuftig ut
                if(!Directory.Exists(SysPar.GenieDirectory + Path.DirectorySeparatorChar + "EXEFILES"))
                {
                    MessageBox.Show("Finner ikke 'EXEFILES' katalogen, sjekk at rett katalog er valgt");
                    Close();
                }

                if (!File.Exists(SysPar.GenieDirectory + Path.DirectorySeparatorChar + "EXEFILES" + Path.DirectorySeparatorChar + "QA.EXE"))
                {
                    MessageBox.Show("Finner ikke QA.EXE, sjekk at 'Quality Assurance Software' pakken er installert");
                    Close();
                }

                // Legg til katalogseparatorer hvis de mangler
                Utils.FixDirectorySeparator(ref SysPar.LimsExport);
                Utils.FixDirectorySeparator(ref SysPar.LimsImport);

                // Kopier programmet mcainfo.exe fra "template" instalasjonskatalogen hvis den ikke finnes fra før
                if (!File.Exists(Config.ExeDir + "mcainfo.exe"))
                    File.WriteAllBytes(Config.ExeDir + "mcainfo.exe", Properties.Resources.TEMPLATE_MCAINFO);                                        

                // Last inn detektor definisjoner fra fil
                Detectors = Utils.DeserializeDetectors();

                // Se etter nye detektorer definert i Genie2k
                if (!LookupNewDetectors())
                {
                    // Deaktiver grensesnitt hvis filen for Genie2k detektordefinisjoner ikke finnes
                    btnMenuRegSample.Enabled = false;
                    btnMenuRefSample.Enabled = false;
                    btnMenuBkgSample.Enabled = false;
                    btnMenuBarcodeWizard.Enabled = false;
                    btnMenuBarcodeWizardRef.Enabled = false;
                    btnMenuBarcodeWizardBkg.Enabled = false;
                }

                // Oppdater detektorer i grensesnittet
                UpdateDetectorLists();

                // Last inn geometrier fra fil
                Beakers = Utils.DeserializeBeakers();

                // Oppdater geometrier i grensesnittet
                cboxAdmQABeaker.Items.Clear();
                for (int i = 0; i < Beakers.Count(); i++)
                {
                    lbAdmGeomList.Items.Add(Beakers[i].Name);
                    //if(Beakers[i].InUse)
                        cboxAdmQABeaker.Items.Add(Beakers[i].Name);
                }

                // Last inn QA-geometrier fra fil
                QABeakers = Utils.DeserializeQABeakers();
                // Oppdater QA-geometrier i grensesnittet
                for (int i = 0; i < QABeakers.Count(); i++)
                {
                    lbAdmQAList.Items.Add(QABeakers[i].Name);
                }

                // Oppdater diverse felter i grensesnittet
                tbAdmGenieFolder.Text = SysPar.GenieDirectory;
                tbAdmSigma.Text = SysPar.ErrorMultiplier.ToString();
                tbAdmTemplate.Text = SysPar.ReportTemplate;
                cboxAdmSection.Text = SysPar.ReportSection;
                cboxAdmPlotScaleY.Text = SysPar.ReportScaleY;
                cboxAdmPlotScaleX.Text = SysPar.ReportScaleX;
                tbAdmLIMSImport.Text = SysPar.LimsImport;
                tbAdmLIMSExport.Text = SysPar.LimsExport;

                cboxSampAdvPreTimeUnit.SelectedIndex = 0;
                cboxAdmDetPresetTimeUnit.SelectedIndex = 0;
                cboxAdmSection.SelectedIndex = 0;
                cboxSampQuantUnit.SelectedIndex = 0;
                cboxAdmQASampUnit.SelectedIndex = 0;
                cboxAdmDetContinuumFunc.SelectedIndex = 0;
                cboxAdmDetEffCalType.SelectedIndex = 0;

                // Start objektet for overvåkning av jobb katalogen
                watcher.Path = Config.JobDir;
                watcher.NotifyFilter = NotifyFilters.FileName;
                watcher.Filter = "*.RPT";
                watcher.Created += new FileSystemEventHandler(OnJobsChanged);
                watcher.Deleted += new FileSystemEventHandler(OnJobsChanged);
                watcher.EnableRaisingEvents = true;

                // Sett opp en "Idle" hendelse for Scintilab
                Application.Idle += new EventHandler(Application_Idle);
            }
            catch (Exception ex)
            {
                // Noe gikk galt under oppstart, vis feilmelding og avslutt
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        /** 
         * Hendelse for program i inaktiv tilstand
         */
        private void Application_Idle(object sender, System.EventArgs e)
        {
            // Sjekk om jobb katalogen trenger oppdatering
            if (updateJobs)
            {
                updateJobs = false;
                updateGridJobs(); // Oppdater jobb informasjon
            }

            // Diverse oppdateringer for grensesnittet
            if (tabs.SelectedTab == pageAdmin && tabsAdmin.SelectedTab == tabAdminQA && btnAdmQANew.Visible == false)
                btnAdmQANew.Visible = true;
            else if((tabs.SelectedTab != pageAdmin || tabsAdmin.SelectedTab != tabAdminQA) && btnAdmQANew.Visible == true)
                btnAdmQANew.Visible = false;

            if (tabs.SelectedTab == pageAdmin && tabsAdmin.SelectedTab == tabAdminGeom && btnAdmGeoNew.Visible == false)
                btnAdmGeoNew.Visible = true;
            else if ((tabs.SelectedTab != pageAdmin || tabsAdmin.SelectedTab != tabAdminGeom) && btnAdmGeoNew.Visible == true)
                btnAdmGeoNew.Visible = false;
        }

        /** 
         * Hendelse for endringer i JOBS katalogen
         */
        private void OnJobsChanged(object source, FileSystemEventArgs e)
        {
            // Hvis jobb katalogen har forandringer, sett en indikator for oppdatering av grensesnittet
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Deleted)
            {
                updateJobs = true;
            }
        }

        /** 
         * Funksjon for å sjekke om det finnes nye detektor definisjoner i Genie2k som ikke er funnet før.
         * Eventuelle nye detektorer vil bli lagt til i Scintilab hvis brukeren ønsker det
         * 
         * @return  Usant hvis Genie2k .WSP filen ikke finnes, Sant ellers
         */
        private bool LookupNewDetectors()
        {
            // Opprett filbane til Genie2k detektor definisjoner
            string machineName = Environment.MachineName;
            string wspFile = SysPar.GenieDirectory + "/MIDFILES/" + machineName + ".WSP";
            if (!File.Exists(wspFile))
            {
                // Genie2k detektor definisjoner ble ikke funnet, vis feilmelding og avslutt
                MessageBox.Show("WSP filen " + wspFile + " ble ikke funnet");
                return false;
            }

            // Les inn detektor definisjoner fra Genie2k
            StreamReader sr = new StreamReader(wspFile);
            bool found;
            while (!sr.EndOfStream)
            {
                found = false;
                string det = sr.ReadLine().Trim(); // Les neste detektornavn fra filen
                for (int i = 0; i < Detectors.Count; i++)
                {
                    if (Detectors[i].Name.ToUpper() == det.ToUpper())
                        found = true; // Detektornavnet finnes fra før
                }

                if (!found)
                {
                    // Ny detektor funnet i Genie2k, spør brukeren om den skal legges til i Scintilab
                     DialogResult res = MessageBox.Show("Vil du legge til detektor " + det + "?" + Environment.NewLine + Environment.NewLine + "Husk å konfigurere nye detektorer under Administrasjonssiden", "Ny detektor funnet", MessageBoxButtons.YesNo);
                     if (res == DialogResult.Yes)
                     {
                         // Opprett og legg til ny detektor
                         Detector newDet = new Detector();
                         newDet.Name = det;
                         Detectors.Add(newDet);
                     }
                }
            }
            return true;
        }

        /** 
         * Funksjon for å sjekke om noe gikk galt under kjøring av .BAT fil.
         * 
         * @param   filename Fil som skal sjekkes for feilmeldinger. Filinnholdet skal være "standard output" fra kjøring av .BAT filen
         * 
         * @return  Sant hvis det ble funnet en feilmelding, Usant ellers
         */
        private bool checkForErrors(string filename)
        {            
            StreamReader sr = new StreamReader(filename);
            string content = sr.ReadToEnd(); // Les inn hele filen
            sr.Close();
            // Returner true hvis ordet " Error " finnes i filen
            return content.IndexOf(" Error ") != -1;
        }

        /** 
         * Funksjon for å oppdatere oversikten over eksisterende jobber
         */
        private void updateGridJobs()
        {
            // Oppdater jobb informasjon
            gridJobs.Rows.Clear(); // Tøm grensesnitt
            string[] batFiles = Directory.GetFiles(Config.JobDir, "*.BAT"); // Finn alle .BAT filer
            foreach (string batFile in batFiles) // For hver .BAT fil
            {
                string status = "Pågår";
                string det = Path.GetFileNameWithoutExtension(batFile);
                // Opprett filbaner til .RPT og .OUT filer
                string rptFile = Path.GetDirectoryName(batFile) + Path.DirectorySeparatorChar + det + ".RPT";
                string outFile = Path.GetDirectoryName(batFile) + Path.DirectorySeparatorChar + det + ".OUT";
                // SJekk om .RPT filen finnes
                if (File.Exists(rptFile))
                {
                    // Sett status til "Ferdig" hvis .BAT filen har en tilhørende .RPT fil
                    status = "Ferdig";
                    lblStatus.Text = "";
                }
                gridJobs.Rows.Add(det, status); // Oppdater grensesnitt
            }
        }

        /** 
         * Hendelse for å vise oversikt over eksisterende jobber
         */
        private void btnMenuJobs_Click(object sender, EventArgs e)
        {
            // Skift til jobb fanen
            tabs.SelectedTab = pageJobs;
        }

        /** 
         * Hendelse for å vise arkivet
         */
        private void btnMenuArchive_Click(object sender, EventArgs e)
        {   
            // Tøm arkiv informasjon i grensesnittet
            tvArchive.Nodes.Clear();

            // Finn alle kataloger under arkivet og oppdater grensesnittet
            char[] seps = { Path.DirectorySeparatorChar };            
            string[] dirs = Directory.GetDirectories(Config.ArchiveDir);            
            foreach (string dir in dirs)
            {
                string[] pathItems = dir.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                TreeNode tn = new TreeNode(pathItems[pathItems.Length - 1]);                
                tvArchive.Nodes.Add(tn);
            }

            // Skift til arkiv fanen
            tabs.SelectedTab = pageArchive;
        }

        /** 
         * Hendelse for å vise administrasjonssidene
         */
        private void MenuItemAdmin_Click(object sender, EventArgs e)
        {
            // Skift til admin fanen
            tabs.SelectedTab = pageAdmin;
        }

        /** 
         * Hendelse for å gå tilbake til hovedmenyen
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Skift til meny fanen
            tabs.SelectedTab = pageMenu;
        }

        /** 
         * Hendelse for skifte av aktivt skilleark
         */
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Diverse oppdateringer i grensesnittet
            lblToolsInterface.Text = tabs.SelectedTab.Text;
            lblStatus.Text = "";

            // Aktiver/Deaktiver "back" knappen basert på valgt fane
            if (tabs.SelectedTab == pageMenu)
                btnBack.Enabled = false;
            else
                btnBack.Enabled = true;

            // Oppdater jobb informasjon hvis valgt fane er jobb fanen
            if(tabs.SelectedTab == pageJobs)
                updateGridJobs();

            // Oppdater grensesnittet hvis valgt fane ikke er prøve informasjon
            if (tabs.SelectedTab != pageSample)
            {
                tabsSamples.SelectedTab = tabSamplesParams;
                tabsBuildup.SelectedTab = tabBuildupNone;

                lblToolsDetector.Text = "";
                isReanal = false;
                cboxSampAdvPreArea.Enabled = true;
                tbSampAdvPreAreaValue.Enabled = true;
                tbSampAdvPreAreaChanFrom.Enabled = true;
                tbSampAdvPreAreaChanTo.Enabled = true;
                cboxSampAdvPreTime.Enabled = true;
                tbSampAdvPreTimeValue.Enabled = true;
                cboxSampAdvPreTimeUnit.Enabled = true;
            }
            else
            {
                // Valgt fane er prøve informasjon

                // Hent valgt detektor
                Detector d = getDetectorByName(lblToolsDetector.Text);

                // Oppdater grensesnittet basert på om dette er en reanalysering eller ikke
                if (isReanal)
                {
                    lblSampIsReanal.Text = "Reanalysering";
                    btnSampStart.Text = "Reanalyser";
                }
                else
                {
                    lblSampIsReanal.Text = "";
                    btnSampStart.Text = "Start";                    
                    tbSampRef.Text = d.Name + DateTime.Now.Year.ToString().Substring(2, 2) + String.Format("{0:0000}", d.SpectrumCounter + 1);
                }
            }

            // Oppdater grensesnittet hvis valgt fane er admin
            if (tabs.SelectedTab != pageAdmin)
            {
                clearAdmBeakers();
                lbAdmGeomList.ClearSelected();
                clearAdmDetectors();
                lbAdmDetList.ClearSelected();
                clearAdmQABeakers();
                lbAdmQAList.ClearSelected();
            }

            // Oppdater grensesnittet hvis valgt fane er detektor meny
            if (tabs.SelectedTab == pageDetectors)
            {
                foreach (ListViewItem item in lvDetectors.Items)
                    item.Selected = false;
            }
        }

        /** 
         * Funksjon som sjekker om en detektor har en aktiv jobb
         * 
         * @param   d Detektor som skal sjekkes
         * 
         * @return  Sant hvis detektoren har en jobb, Usant ellers
         */
        private bool DetectorHasJob(Detector d)
        {
            if (File.Exists(Config.JobDir + d.Name + ".BAT"))
                return true; // Detektoren har en .BAT fil i jobb katalogen
            return false;
        }

        /** 
         * Hendelse for valg av detektor
         */
        private void lvDetectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDetectors.SelectedIndices.Count == 0) // Avbryt hvis ingen detektor er valgt
                return;
            
            Detector d = getDetectorByName(lvDetectors.SelectedItems[0].Text);

            // Hvis valgt detektor allerede har en pågående jobb, gå til jobb info og avbryt
            if (DetectorHasJob(d))
            {
                tabs.SelectedTab = pageJobs;
                return;
            }

            // Oppdater status
            lblStatus.Text = "Sjekker om detektor " + d.Name + " er klar";
            Application.DoEvents();

            // SJekk om detektor er klar for bruk
            if (!Utils.IsDetectorReady(d, ref lblStatus))
            {
                tabs.SelectedTab = pageMenu;
                return;
            }
            
            // Lagre valgt detektor i parameter strukturen og fyll inn felter i prøveinfo
            SelInfo.SelectedDetector = d;
            populateSampleView(SelInfo);
        }

        /** 
         * Funksjon for å sette alle prøveinfofelter til enten aktiv eller inaktiv
         * 
         * @param   enable Status som feltene skal settes til
         */
        private void SetSampleFieldsStatus(bool enable)
        {
            // Sett status på alle felter i prøveinfo
            btnSampReadBarcode.Enabled = enable;
            tbSampOrder.Enabled = enable;
            tbSampDesc.Enabled = enable;
            tbSampID.Enabled = enable;
            tbSampType.Enabled = enable;
            tbSampQuant.Enabled = enable;
            tbSampQuantUnc.Enabled = enable;
            cboxSampQuantUnit.Enabled = enable;
            cboxSampGeom.Enabled = enable;
            tbSampComment.Enabled = enable;
            tabsBuildup.Enabled = enable;
            cboxSampAdvCal.Enabled = enable;
            tbSampAdvRandErr.Enabled = enable;
            tbSampAdvSystErr.Enabled = enable;
            cboxSampAdvPreArea.Enabled = enable;
            tbSampAdvPreAreaValue.Enabled = enable;
            tbSampAdvPreAreaChanFrom.Enabled = enable;
            tbSampAdvPreAreaChanTo.Enabled = enable;
            cboxSampAdvPreTime.Enabled = enable;
            tbSampAdvPreTimeValue.Enabled = enable;
            cboxSampAdvPreTimeUnit.Enabled = enable;
            tbSampAnalTolerance.Enabled = enable;
            tbSampAnalSigThresh.Enabled = enable;
            tbSampAnalContinuum.Enabled = enable;
            cboxSampAnalContinuumFunc.Enabled = enable;
            cbSampAnalCritLev.Enabled = enable;
            cbSampAnalFitSinglets.Enabled = enable;
            cbSampAnalDispRois.Enabled = enable;
            cbSampAnalUseFixed.Enabled = enable;
            cbSampAnalRejectZero.Enabled = enable;
            cbSampAnalFixedFWHM.Enabled = enable;
            cboxSampAnalEffCal.Enabled = enable;
            tbSampAnalMaxFWHMBetween.Enabled = enable;
            tbSampAnalMaxFWHMLeft.Enabled = enable;
            tbSampAnalMaxFWHMRight.Enabled = enable;
            tbSampAnalBkgSub.Enabled = enable;
            tbSampAnalNIDLib.Enabled = enable;
            tbSampAnalNIDConfThresh.Enabled = enable;
            tbSampAnalMDAConfFac.Enabled = enable;
            cbSampAnalInhibitATD.Enabled = enable;
            cbSampAnalUseStoredLib.Enabled = enable;
            cbSampAnalPerformMDA.Enabled = enable;
            btnSampAnalBkgSub.Enabled = enable;
            btnSampAnalNIDLib.Enabled = enable;
        }

        /** 
         * Hendelse for innlesing av strekkode for en prøve
         */
        private void btnSampReadBarcode_Click(object sender, EventArgs e)
        {
            // Les inn strekkode fra bruker
            FormBarcodeSample form = new FormBarcodeSample();
            form.LimsExpDir = SysPar.LimsExport;
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Fyll inn felter i prøveinfo basert på fil valgt med strekkode
                populateSampGeom(lblToolsDetector.Text);
                populateSampleFromFile(form.LimsFile);
            }
        }

        /** 
         * Hendelse for valg av detektor under administrasjonssidene
         */
        private void lbAdmDetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Deaktiver høyre panel hvis ingen detektor er valgt
            if (lbAdmDetList.SelectedIndices.Count == 0)
            {
                splitAdmDet.Panel2.Enabled = false;
                return;
            }

            // Fyll inn felter under admin detektor info med valgt detektor
            splitAdmDet.Panel2.Enabled = true;
            Detector d = getDetectorByName(lbAdmDetList.SelectedItem.ToString());
            clearAdmDetectors();
            cbAdmDetInUse.Checked = d.InUse;
            tbAdmDetSearchRegionFrom.Text = d.SearchRegionFrom.ToString();
            tbAdmDetSearchRegionTo.Text = d.SearchRegionTo.ToString(); 
            tbAdmDetTolerance.Text = d.Tolerance.ToString();
            tbAdmDetSignThresh.Text = d.SignificanceThreshold.ToString();
            tbAdmDetPeakAreaRegionFrom.Text = d.PeakAreaRegionFrom.ToString();
            tbAdmDetPeakAreaRegionTo.Text = d.PeakAreaRegionTo.ToString();
            tbAdmDetContinuum.Text = d.Continuum.ToString();
            cboxAdmDetContinuumFunc.Text = d.ContinuumFunction;
            cbAdmDetCriticalLevel.Checked = d.CriticalLevel;
            cbAdmDetFitSinglets.Checked = d.FitSinglets;
            cbAdmDetDisplayROIs.Checked = d.DisplayROIs;
            cbAdmDetUseFixedTailParam.Checked = d.UseFixedTailParameter;
            cbAdmDetRejectZeroAreaPeaks.Checked = d.RejectZeroAreaPeaks;
            cbAdmDetUseFixedFWHM.Checked = d.UseFixedFWHM;
            tbAdmDetMaxFHWMBetPeaks.Text = d.MaxFWHMSBetweenPeaks.ToString();
            tbAdmDetMaxFHWMLeftLim.Text = d.MaxFWHMSForLeftLimit.ToString();
            tbAdmDetMaxFHWMRightLim.Text = d.MaxFWHMSForRightLimit.ToString();
            tbAdmDetBkgSub.Text = d.BackgroundSubtract;
            cboxAdmDetEffCalType.Text = d.EfficiencyCalibrationType;
            tbAdmDetNIDLib.Text = d.NIDLibrary;
            tbAdmDetNIDConfThresh.Text = d.NIDConfidenceThreshold.ToString();
            tbAdmDetMDAConfFac.Text = d.MDAConfidenceFactor.ToString();
            cbAdmDetInhibitATDCorr.Checked = d.InhibitATDCorrection;
            cbAdmDetUseStoredLib.Checked = d.UseStoredLibrary;
            cbAdmDetPerfMDATest.Checked = d.PerformMDATest;
            cboxAdmDetPresetArea.Text = d.PresetCount;
            tbAdmDetPresetAreaValue.Text = d.PresetCountValue.ToString();
            tbAdmDetPresetAreaChanFrom.Text = d.PresetCountChanFrom.ToString();
            tbAdmDetPresetAreaChanTo.Text = d.PresetCountChanTo.ToString();
            cboxAdmDetPresetTime.Text = d.PresetTime;
            tbAdmDetPresetTimeValue.Text = d.PresetTimeValue.ToString();
            cboxAdmDetPresetTimeUnit.Text = d.PresetTimeUnit;
            tbAdmDetRandErr.Text = d.RandomError.ToString();
            tbAdmDetSysErr.Text = d.SystematicError.ToString();
            // Fyll inn grid for beaker/calibration/QA for valgt detektor
            for (int j = 0; j < d.BeakerInfoList.Count; j++)
            {
                BeakerInfo bi = d.BeakerInfoList[j];
                gridAdmDetGeomCalQA.Rows.Add(bi.BeakerName, bi.CalibrationFile, bi.QAName);
            }

            cboxAdmDetQAPresetArea.Text = d.QARefPresetArea;
            tbAdmDetQAPresetAreaValue.Text = d.QARefPresetAreaValue.ToString();
            tbAdmDetQAPresetAreaChanFrom.Text = d.QARefPresetAreaChanFrom.ToString();
            tbAdmDetQAPresetAreaChanTo.Text = d.QARefPresetAreaChanTo.ToString();

            cboxAdmDetQAPresetTime.Text = d.QARefPresetTime;
            tbAdmDetQAPresetTimeValue.Text = d.QARefPresetTimeValue.ToString();
            cboxAdmDetQAPresetTimeUnit.Text = d.QARefPresetTimeUnit;

            cboxAdmDetBkgPresetArea.Text = d.QABkgPresetArea;
            tbAdmDetBkgPresetAreaValue.Text = d.QABkgPresetAreaValue.ToString();
            tbAdmDetBkgPresetAreaChanFrom.Text = d.QABkgPresetAreaChanFrom.ToString();
            tbAdmDetBkgPresetAreaChanTo.Text = d.QABkgPresetAreaChanTo.ToString();

            cboxAdmDetBkgPresetTime.Text = d.QABkgPresetTime;
            tbAdmDetBkgPresetTimeValue.Text = d.QABkgPresetTimeValue.ToString();
            cboxAdmDetBkgPresetTimeUnit.Text = d.QABkgPresetTimeUnit;
        }

        /** 
         * Hendelse for valg av beger under administrasjonssidene
         */
        private void lbAdmGeomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avslutt hvis ingen geometri er valgt
            if (lbAdmGeomList.SelectedIndices.Count == 0)
            {
                splitAdmGeom.Panel2.Enabled = false;
                return;
            }

            // Fyll inn felter under admin beaker info for valgt beger
            splitAdmGeom.Panel2.Enabled = true;
            clearAdmBeakers();
            Beaker b = getBeakerByName(lbAdmGeomList.SelectedItem.ToString());
            cbAdmGeomInUse.Checked = b.InUse;
            tbAdmGeomManufacturer.Text = b.Manufacturer;
        }

        /** 
         * Hendelse for valg av QA-beger under administrasjonssidene
         */
        private void lbAdmQAList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avbryt hvis ingen QA-beger er valgt
            if (lbAdmQAList.SelectedIndices.Count == 0)
            {
                splitAdmQA.Panel2.Enabled = false;
                return;
            }

            // Fyll inn felter under admin QA-beger info med valgt QA-beger
            splitAdmQA.Panel2.Enabled = true;
            clearAdmQABeakers();
            QABeaker b = getQABeakerByName(lbAdmQAList.SelectedItem.ToString());
            cbAdmQAInUse.Checked = b.InUse;
            cboxAdmQABeaker.Text = b.BeakerName;
            dtAdmQARefDate.Value = b.RefDate;
            dtAdmQARefTime.Value = b.RefDate;
            tbAdmQASampType.Text = b.SampleType;
            tbAdmQASampQuant.Text = b.SampleQuantity.ToString();
            cboxAdmQASampUnit.Text = b.Unit;
            tbAdmQASampUnc.Text = b.Uncertainty.ToString();
        }

        /** 
         * Hendelse for valg av beger under prøveinfo
         */
        private void cboxSampGeom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avbryt hvis ingen beger er valgt
            if (String.IsNullOrEmpty(cboxSampGeom.Text))
                return;

            // Fyll inn .CAL filer for valgt detektor/beger
            Detector d = getDetectorByName(lblToolsDetector.Text);
            string beakerName = cboxSampGeom.Text;
            for (int i = 0; i < d.BeakerInfoList.Count; i++)
                if (beakerName.ToUpper() == d.BeakerInfoList[i].BeakerName.ToUpper())
                    addCalFilesToSamp(d, beakerName);
            
            if (!isReanal)
            {
                if (SelInfo.AnalType == "Ref")
                {
                    // Fyll inn felter for referanse målinger
                    string qabName = getQABoxFromDetector(d, beakerName);
                    QABeaker qab = getQABeakerByName(qabName);
                    tbSampDesc.Text = "Referansemåling " + DateTime.Now.ToShortDateString();
                    tbSampQuant.Text = qab.SampleQuantity.ToString();
                    tbSampID.Text = qabName;
                    tbSampType.Text = qab.SampleType;
                    cboxSampQuantUnit.Text = qab.Unit;
                    tbSampQuantUnc.Text = qab.Uncertainty.ToString();
                    dtSampBuildNoneDate.Value = qab.RefDate;
                    dtSampBuildNoneTime.Value = qab.RefDate;
                }
            }
        }

        /** 
         * Hendelse for lagring av detektor under administrasjonssidene
         */
        private void btnAdmDetSave_Click(object sender, EventArgs e)
        {
            // Sjekk at påkrevde felter er fyllt inn
            if (!String.IsNullOrEmpty(cboxAdmDetQAPresetArea.Text))
            {
                if (String.IsNullOrEmpty(tbAdmDetQAPresetAreaValue.Text)
                    || String.IsNullOrEmpty(tbAdmDetQAPresetAreaChanFrom.Text)
                    || String.IsNullOrEmpty(tbAdmDetQAPresetAreaChanTo.Text))
                {
                    MessageBox.Show("En eller fler påkrevde felter mangler for ref. boks - preset area");
                    return;
                }
            }
            else
            {
                // Sett inn default verdier for noen felter
                tbAdmDetQAPresetAreaValue.Text = "0";
                tbAdmDetQAPresetAreaChanFrom.Text = "0";
                tbAdmDetQAPresetAreaChanTo.Text = "0";
            }

            if (!String.IsNullOrEmpty(cboxAdmDetQAPresetTime.Text))
            {
                if (String.IsNullOrEmpty(tbAdmDetQAPresetTimeValue.Text) || String.IsNullOrEmpty(cboxAdmDetQAPresetTimeUnit.Text))
                {
                    MessageBox.Show("En eller fler påkrevde felter mangler for ref. boks - preset time");
                    return;
                }
            }
            else tbAdmDetQAPresetTimeValue.Text = "0";

            if (String.IsNullOrEmpty(cboxAdmDetQAPresetArea.Text) && String.IsNullOrEmpty(cboxAdmDetQAPresetTime.Text))
            {
                MessageBox.Show("Du må sette enten preset area eller preset time for ref. boks");
                return;
            }


            if (!String.IsNullOrEmpty(cboxAdmDetBkgPresetArea.Text))
            {
                if (String.IsNullOrEmpty(tbAdmDetBkgPresetAreaValue.Text)
                    || String.IsNullOrEmpty(tbAdmDetBkgPresetAreaChanFrom.Text)
                    || String.IsNullOrEmpty(tbAdmDetBkgPresetAreaChanTo.Text))
                {
                    MessageBox.Show("En eller fler påkrevde felter mangler for ref. boks - preset area");
                    return;
                }
            }
            else
            {
                tbAdmDetBkgPresetAreaValue.Text = "0";
                tbAdmDetBkgPresetAreaChanFrom.Text = "0";
                tbAdmDetBkgPresetAreaChanTo.Text = "0";
            }

            if (!String.IsNullOrEmpty(cboxAdmDetBkgPresetTime.Text))
            {
                if (String.IsNullOrEmpty(tbAdmDetBkgPresetTimeValue.Text) || String.IsNullOrEmpty(cboxAdmDetBkgPresetTimeUnit.Text))
                {
                    MessageBox.Show("En eller fler påkrevde felter mangler for ref. boks - preset time");
                    return;
                }
            }
            else tbAdmDetBkgPresetTimeValue.Text = "0";

            if (String.IsNullOrEmpty(cboxAdmDetBkgPresetArea.Text) && String.IsNullOrEmpty(cboxAdmDetBkgPresetTime.Text))
            {
                MessageBox.Show("Du må sette enten preset area eller preset time for ref. boks");
                return;
            }

            // SJekk at NID Conf. Thresh. er større enn 0 og mindre enn 1
            double nct = Utils.ConvertToDouble(tbAdmDetNIDConfThresh.Text);
            if (!(nct > 0.0 && nct < 1.0))
            {
                MessageBox.Show("NID Conf. Thresh. må være større enn 0.0 og mindre enn 1.0");
                return;
            }

            try
            {
                // Fyll valgt detektor med verdier fra felter
                Detector d = getDetectorByName(lbAdmDetList.SelectedItem.ToString());
                d.InUse = cbAdmDetInUse.Checked;
                d.SearchRegionFrom = Convert.ToInt32(tbAdmDetSearchRegionFrom.Text);
                d.SearchRegionTo = Convert.ToInt32(tbAdmDetSearchRegionTo.Text);
                d.Tolerance = Utils.ConvertToDouble(tbAdmDetTolerance.Text);
                d.SignificanceThreshold = Utils.ConvertToDouble(tbAdmDetSignThresh.Text);
                d.PeakAreaRegionFrom = Convert.ToInt32(tbAdmDetPeakAreaRegionFrom.Text);
                d.PeakAreaRegionTo = Convert.ToInt32(tbAdmDetPeakAreaRegionTo.Text);
                d.Continuum = Utils.ConvertToDouble(tbAdmDetContinuum.Text);
                d.ContinuumFunction = cboxAdmDetContinuumFunc.Text;
                d.CriticalLevel = cbAdmDetCriticalLevel.Checked;
                d.FitSinglets = cbAdmDetFitSinglets.Checked;
                d.DisplayROIs = cbAdmDetDisplayROIs.Checked;
                d.UseFixedTailParameter = cbAdmDetUseFixedTailParam.Checked;
                d.RejectZeroAreaPeaks = cbAdmDetRejectZeroAreaPeaks.Checked;
                d.UseFixedFWHM = cbAdmDetUseFixedFWHM.Checked;
                d.MaxFWHMSBetweenPeaks = Utils.ConvertToDouble(tbAdmDetMaxFHWMBetPeaks.Text);
                d.MaxFWHMSForLeftLimit = Utils.ConvertToDouble(tbAdmDetMaxFHWMLeftLim.Text);
                d.MaxFWHMSForRightLimit = Utils.ConvertToDouble(tbAdmDetMaxFHWMRightLim.Text);
                d.BackgroundSubtract = tbAdmDetBkgSub.Text;
                d.EfficiencyCalibrationType = cboxAdmDetEffCalType.Text;
                d.NIDLibrary = tbAdmDetNIDLib.Text;
                d.NIDConfidenceThreshold = Utils.ConvertToDouble(tbAdmDetNIDConfThresh.Text);
                d.MDAConfidenceFactor = Utils.ConvertToDouble(tbAdmDetMDAConfFac.Text);
                d.InhibitATDCorrection = cbAdmDetInhibitATDCorr.Checked;
                d.UseStoredLibrary = cbAdmDetUseStoredLib.Checked;
                d.PerformMDATest = cbAdmDetPerfMDATest.Checked;
                d.PresetCount = cboxAdmDetPresetArea.Text;
                d.PresetCountValue = Convert.ToInt32(tbAdmDetPresetAreaValue.Text);
                d.PresetCountChanFrom = Convert.ToInt32(tbAdmDetPresetAreaChanFrom.Text);
                d.PresetCountChanTo = Convert.ToInt32(tbAdmDetPresetAreaChanTo.Text);
                d.PresetTime = cboxAdmDetPresetTime.Text;
                d.PresetTimeValue = Convert.ToInt32(tbAdmDetPresetTimeValue.Text);
                d.PresetTimeUnit = cboxAdmDetPresetTimeUnit.Text;
                d.RandomError = Utils.ConvertToDouble(tbAdmDetRandErr.Text);
                d.SystematicError = Utils.ConvertToDouble(tbAdmDetSysErr.Text);
                d.BeakerInfoList.Clear();
                for (int i = 0; i < gridAdmDetGeomCalQA.Rows.Count; i++)
                {
                    BeakerInfo bi = new BeakerInfo();
                    bi.BeakerName = gridAdmDetGeomCalQA.Rows[i].Cells["Geom"].Value as String;
                    bi.CalibrationFile = gridAdmDetGeomCalQA.Rows[i].Cells["CalFile"].Value as String;
                    bi.QAName = gridAdmDetGeomCalQA.Rows[i].Cells["QABeaker"].Value as String;
                    d.BeakerInfoList.Add(bi);
                }

                d.QARefPresetArea = cboxAdmDetQAPresetArea.Text;
                if (!String.IsNullOrEmpty(tbAdmDetQAPresetAreaValue.Text))
                    d.QARefPresetAreaValue = Convert.ToInt32(tbAdmDetQAPresetAreaValue.Text);
                if (!String.IsNullOrEmpty(tbAdmDetQAPresetAreaChanFrom.Text))
                    d.QARefPresetAreaChanFrom = Convert.ToInt32(tbAdmDetQAPresetAreaChanFrom.Text);
                if (!String.IsNullOrEmpty(tbAdmDetQAPresetAreaChanTo.Text))
                    d.QARefPresetAreaChanTo = Convert.ToInt32(tbAdmDetQAPresetAreaChanTo.Text);

                d.QARefPresetTime = cboxAdmDetQAPresetTime.Text;
                if (!String.IsNullOrEmpty(tbAdmDetQAPresetTimeValue.Text))
                    d.QARefPresetTimeValue = Convert.ToInt32(tbAdmDetQAPresetTimeValue.Text);
                d.QARefPresetTimeUnit = cboxAdmDetQAPresetTimeUnit.Text;

                d.QABkgPresetArea = cboxAdmDetBkgPresetArea.Text;
                if (!String.IsNullOrEmpty(tbAdmDetBkgPresetAreaValue.Text))
                    d.QABkgPresetAreaValue = Convert.ToInt32(tbAdmDetBkgPresetAreaValue.Text);
                if (!String.IsNullOrEmpty(tbAdmDetBkgPresetAreaChanFrom.Text))
                    d.QABkgPresetAreaChanFrom = Convert.ToInt32(tbAdmDetBkgPresetAreaChanFrom.Text);
                if (!String.IsNullOrEmpty(tbAdmDetBkgPresetAreaChanTo.Text))
                    d.QABkgPresetAreaChanTo = Convert.ToInt32(tbAdmDetBkgPresetAreaChanTo.Text);

                d.QABkgPresetTime = cboxAdmDetBkgPresetTime.Text;
                if (!String.IsNullOrEmpty(tbAdmDetBkgPresetTimeValue.Text))
                    d.QABkgPresetTimeValue = Convert.ToInt32(tbAdmDetBkgPresetTimeValue.Text);
                d.QABkgPresetTimeUnit = cboxAdmDetBkgPresetTimeUnit.Text;

                // Lagre detektor tilbake til fil
                Utils.SerializeDetectors(Detectors);

                // Logg aktivitet
                Config.LogMessage("Admin Detektorer lagret");

                lblStatus.Text = "Detector " + d.Name + " ble lagret";
            }
            catch (Exception ex)
            {
                // Rapporter feil
                MessageBox.Show(ex.Message + " Sjekk at desimaler har riktig format");
            }
        }

        /** 
         * Funksjon for å be brukeren velge en fil
         * 
         * @param   title Tittel på filvelgeren
         * @param   dir Startkatalog for filvelgeren 
         * @param   filter Filter for filvelgeren
         * 
         * @return  Filbanen til valgt fil, eller tom streng hvis brukeren avbryter
         */
        private string getFile(string title, string dir, string filter)
        {
            // Fyll inn dialog med default verdier
            ofd.InitialDirectory = dir;
            ofd.Filter = filter;
            ofd.Title = title;
            // Vis dialog og returner valgt filbane
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return ofd.FileName;
            return "";
        }

        /** 
         * Funksjon for å be brukeren velge en katalog
         * 
         * @param   title Tittel på katalogvelgeren         
         * 
         * @return  Katalogbanen til valgt katalog, eller tom streng hvis brukeren avbryter
         */
        private string getFolder(string title)
        {
            // Fyll inn dialog med default verdier
            fbd.SelectedPath = Path.GetPathRoot(Environment.SystemDirectory);            
            fbd.ShowNewFolderButton = false;
            fbd.Description = title;
            // Vis dialog og returner valgt katalogbane
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fbd.SelectedPath;
            return "";
        }

        /** 
         * Hendelse for valg av en detektors bakgrunnsfil under administrasjonssidene
         */
        private void btnAdmDetBkgSub_Click(object sender, EventArgs e)
        {
            if (lbAdmDetList.SelectedIndices.Count == 0)
                return;
            // Sett opp filter
            string filter = "Bakgrunnsfiler|" + lbAdmDetList.SelectedItem.ToString() + "*.CNF";
            string bkgfile = getFile("Velg bakgrunnsfil", Config.BkgDir, filter);
            if (!String.IsNullOrEmpty(bkgfile))
                tbAdmDetBkgSub.Text = bkgfile;
        }

        /** 
         * Hendelse for valg av en detektors NID-bibliotek under administrasjonssidene
         */
        private void btnAdmDetNIDLib_Click(object sender, EventArgs e)
        {
            string nlbfile = getFile("Velg NID Bibliotek", Config.LibDir, "NID Bibliotek|*.NLB");
            if (!String.IsNullOrEmpty(nlbfile))
                tbAdmDetNIDLib.Text = nlbfile;
        }

        /** 
         * Hendelse for ny kobling av en detektors beger og .CAL fil under administrasjonssidene
         */
        private void btnAdmDetGeomCalAdd_Click(object sender, EventArgs e)
        {
            List<string> usedGeoms = new List<string>(); // Liste med beger som allerede er i bruk
            // Fyll inn liste
            foreach (DataGridViewRow row in gridAdmDetGeomCalQA.Rows)
                usedGeoms.Add(row.Cells[0].Value as String);

            // Vis vindu for ny beger/CAL kombinasjon
            FormCreateGeomCalQA form = new FormCreateGeomCalQA(lbAdmDetList.SelectedItem.ToString(), ref usedGeoms, ref Beakers, ref QABeakers, Config.CalDir);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Legg til ny beger/CAL kombinasjon i grensesnitt
                gridAdmDetGeomCalQA.Rows.Add(form.SelectedGeometry, Config.CalDir + form.SelectedCalFile, form.SelectedQABox); 
            }
        }

        /** 
         * Hendelse for redigering av kobling av en detektors beger og .CAL fil under administrasjonssidene
         */
        private void btnAdmDetGeomCalEdit_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen beger/CAL kombinasjon er valgt
            if (gridAdmDetGeomCalQA.SelectedCells.Count == 0)
                return;

            // Vis vindu for editering av beger/QA kombinasjon
            string geom = gridAdmDetGeomCalQA.SelectedCells[0].Value as String;
            FormEditGeomCalQA form = new FormEditGeomCalQA(lbAdmDetList.SelectedItem.ToString(), geom, ref QABeakers, Config.CalDir);
            form.CurrentCalFile = gridAdmDetGeomCalQA.SelectedCells[1].Value as String;
            form.CurrentQABox = gridAdmDetGeomCalQA.SelectedCells[2].Value as String;
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Oppdater grensesnitt
                gridAdmDetGeomCalQA.SelectedCells[1].Value = form.SelectedCalFile;
                gridAdmDetGeomCalQA.SelectedCells[2].Value = form.SelectedQABox;
            }
        }

        /** 
         * Funksjon for å fylle inn feltene under prøveinfo fra en fil
         * 
         * @param   filename Filbanen til filen med parametere
         */
        private bool populateSampleFromFile(string filename)
        {
            // Fyll inn felter under prøve info med parametere fra fil
            string line;
            StreamReader sr = File.OpenText(filename);
            line = sr.ReadLine();
            char[] sep = { '|' };
            string[] Items = line.Split(sep);

            string geom = Items[6];
            if (cboxSampGeom.FindStringExact(geom) == -1)
            {
                MessageBox.Show("Geometrien " + geom + " finnes ikke for detektor " + lblToolsDetector.Text);
                sr.Close();
                return false;
            }

            tbSampOrder.Text = Items[0];
            tbSampID.Text = Items[1];
            tbSampType.Text = Items[2];
            tbSampQuant.Text = Items[3];
            tbSampQuantUnc.Text = Items[4];
            cboxSampQuantUnit.Text = Items[5];
            cboxSampGeom.Text = geom;
            DateTime dt = DateTime.Parse(Items[7]);
            dtSampBuildNoneDate.Value = dt;
            dtSampBuildNoneTime.Value = dt;
            tbSampComment.Text = Items[8];
            tabsSamples.SelectedTab = tabSamplesParams;
            tabsBuildup.SelectedTab = tabBuildupNone;
            tabs.SelectedTab = pageSample;
            sr.Close();
            return true;
        }

        /** 
         * Hendelse som starter en ny jobb
         */
        private void btnSampStart_Click(object sender, EventArgs e)
        {
            // Sjekk at alle påkrevde felter er fyllt inn og at verdier er gyldige
            if (String.IsNullOrEmpty(tbSampAnalTolerance.Text)
                || String.IsNullOrEmpty(tbSampAnalSigThresh.Text)
                || String.IsNullOrEmpty(tbSampAnalContinuum.Text)
                || String.IsNullOrEmpty(cboxSampAnalContinuumFunc.Text)
                || String.IsNullOrEmpty(tbSampAnalMaxFWHMBetween.Text)
                || String.IsNullOrEmpty(tbSampAnalMaxFWHMLeft.Text)
                || String.IsNullOrEmpty(tbSampAnalMaxFWHMRight.Text)
                || String.IsNullOrEmpty(tbSampRef.Text)
                || String.IsNullOrEmpty(tbSampCollector.Text))
            {
                MessageBox.Show("En eller flere påkrevde felter er tomme");
                return;
            }

            if (String.IsNullOrEmpty(cboxSampAdvPreArea.Text) && String.IsNullOrEmpty(cboxSampAdvPreTime.Text))
            {
                MessageBox.Show("Preset: En eller flere påkrevde felter er tomme");
                return;
            }

            if (!String.IsNullOrEmpty(cboxSampAdvPreArea.Text))
            {
                if (String.IsNullOrEmpty(tbSampAdvPreAreaValue.Text)
                    || String.IsNullOrEmpty(tbSampAdvPreAreaChanFrom.Text)
                    || String.IsNullOrEmpty(tbSampAdvPreAreaChanTo.Text))
                {
                    MessageBox.Show("Preset: En eller flere påkrevde felter er tomme");
                    return;
                }   
            }

            /*if (String.IsNullOrEmpty(cboxSampAdvPreArea.Text))
            {
                if (!String.IsNullOrEmpty(tbSampAdvPreAreaValue.Text)
                    || !String.IsNullOrEmpty(tbSampAdvPreAreaChanFrom.Text)
                    || !String.IsNullOrEmpty(tbSampAdvPreAreaChanTo.Text))
                {
                    MessageBox.Show("Preset: En eller flere ikke-påkrevde felter er fyllt inn");
                    return;
                }
            }*/

            if (!String.IsNullOrEmpty(cboxSampAdvPreTime.Text))
            {
                if (String.IsNullOrEmpty(tbSampAdvPreTimeValue.Text)
                    || String.IsNullOrEmpty(cboxSampAdvPreTimeUnit.Text))
                {
                    MessageBox.Show("Preset: En eller flere påkrevde felter er tomme");
                    return;
                }
            }

            /*if (String.IsNullOrEmpty(cboxSampAdvPreTime.Text))
            {
                if (!String.IsNullOrEmpty(tbSampAdvPreTimeValue.Text))
                {
                    MessageBox.Show("Preset: En eller flere ikke-påkrevde felter er fyllt inn");
                    return;
                }
            }*/

            if (SelInfo.AnalType != "Bkg")
            {
                if (String.IsNullOrEmpty(cboxSampAnalEffCal.Text)
                    || String.IsNullOrEmpty(tbSampAnalBkgSub.Text)
                    || String.IsNullOrEmpty(tbSampAnalNIDLib.Text)
                    || String.IsNullOrEmpty(tbSampAnalNIDConfThresh.Text)
                    || String.IsNullOrEmpty(tbSampAnalMDAConfFac.Text)
                    || String.IsNullOrEmpty(cboxSampAdvCal.Text)
                    || String.IsNullOrEmpty(tbSampAdvRandErr.Text)
                    || String.IsNullOrEmpty(tbSampAdvSystErr.Text)
                    || String.IsNullOrEmpty(tbSampID.Text)
                    || String.IsNullOrEmpty(tbSampType.Text)
                    || String.IsNullOrEmpty(cboxSampGeom.Text)
                    || String.IsNullOrEmpty(tbSampQuant.Text)
                    || String.IsNullOrEmpty(cboxSampQuantUnit.Text)
                    || String.IsNullOrEmpty(tbSampQuantUnc.Text))
                {
                    MessageBox.Show("En eller flere påkrevde felter er tomme");
                    return;
                }
            }

            // Opprett og fyll inn datastruktur for jobb parametere
            JobParams jp = new JobParams();
            Detector d = getDetectorByName(lblToolsDetector.Text);

            jp.Operation = SelInfo.AnalType;
            jp.OrderName = tbSampOrder.Text;
            jp.CollectorName = tbSampCollector.Text;
            jp.Description = tbSampDesc.Text;
            jp.SpecRef = tbSampRef.Text;
            jp.Comment = tbSampComment.Text;
            jp.SampleID = tbSampID.Text;
            jp.SampleType = tbSampType.Text;
            if (!String.IsNullOrEmpty(tbSampQuant.Text))
                jp.SampleQuantity = Utils.ConvertToDouble(tbSampQuant.Text);
            else jp.SampleQuantity = 0;
            if (!String.IsNullOrEmpty(tbSampQuantUnc.Text))
                jp.SampleQuantityError = Utils.ConvertToDouble(tbSampQuantUnc.Text);
            else jp.SampleQuantityError = 0;
            jp.SampleQuantityUnit = cboxSampQuantUnit.Text;
            jp.Geometry = cboxSampGeom.Text;
            jp.DetectorName = d.Name;

            if (jp.Operation == "Ref")
            {
                string qabox = getQABoxFromDetector(d, jp.Geometry);
                if (String.IsNullOrEmpty(qabox))
                {
                    MessageBox.Show("Kan ikke finne QA boks for detektor " + d.Name + " og beger " + jp.Geometry);
                    btnBack_Click(sender, e);
                    return;
                }

                string qafFile = Config.QADir + jp.DetectorName + "-" + jp.Geometry + "-" + qabox + ".QAF";
                if (!File.Exists(qafFile))
                {
                    string defQafFile = Config.ScintilabDir + "DEFAULT-" + qabox + ".QAF";
                    if (!File.Exists(defQafFile))
                    {
                        MessageBox.Show("Mangler default QA fil " + defQafFile + ", kan ikke fortsette");
                        btnBack_Click(sender, e);
                        return;
                    }
                    File.Copy(defQafFile, qafFile, true);
                }
            }

            jp.CalibrationFile = Config.CalDir + cboxSampAdvCal.Text;
            jp.SpectrumDate = DateTime.Now;
            jp.BuildupType = tabsBuildup.SelectedTab.Text.ToUpper();
            if(jp.BuildupType == "NONE")
            {
                string dtstr = dtSampBuildNoneDate.Value.ToShortDateString() + " " + dtSampBuildNoneTime.Value.ToLongTimeString();
                jp.BuildupStartDate = DateTime.Parse(dtstr);
                jp.BuildupEndDate = jp.BuildupStartDate; 
            }
            else if (jp.BuildupType == "IRRAD")
            {
                string dtstr = dtSampBuildIrradDateFrom.Value.ToShortDateString() + " " + dtSampBuildIrradTimeFrom.Value.ToLongTimeString();
                jp.BuildupStartDate = DateTime.Parse(dtstr);
                dtstr = dtSampBuildIrradDateTo.Value.ToShortDateString() + " " + dtSampBuildIrradTimeTo.Value.ToLongTimeString();
                jp.BuildupEndDate = DateTime.Parse(dtstr);
            }
            else if (jp.BuildupType == "DEPOSIT")
            {
                string dtstr = dtSampBuildDepDateFrom.Value.ToShortDateString() + " " + dtSampBuildDepTimeFrom.Value.ToLongTimeString();
                jp.BuildupStartDate = DateTime.Parse(dtstr);
                dtstr = dtSampBuildDepDateTo.Value.ToShortDateString() + " " + dtSampBuildDepTimeTo.Value.ToLongTimeString();
                jp.BuildupEndDate = DateTime.Parse(dtstr);
            }
            if (!String.IsNullOrEmpty(tbSampAdvRandErr.Text))
                jp.RandomError = Utils.ConvertToDouble(tbSampAdvRandErr.Text);
            else jp.RandomError = 0;
            if (!String.IsNullOrEmpty(tbSampAdvSystErr.Text))
                jp.SystematicError = Utils.ConvertToDouble(tbSampAdvSystErr.Text);
            else jp.SystematicError = 0;
            jp.PresetCount = cboxSampAdvPreArea.Text;
            if (!String.IsNullOrEmpty(jp.PresetCount))
            {
                if (tbSampAdvPreAreaChanFrom.Text.Trim() == "0" || tbSampAdvPreAreaChanFrom.Text.Trim() == "0" || tbSampAdvPreAreaValue.Text.Trim() == "0")
                {
                    MessageBox.Show("Kan ikke bruke 0 som verdi i kanaler eller tellere");
                    return;
                }
            }
            if (!String.IsNullOrEmpty(tbSampAdvPreAreaValue.Text))
                jp.PresetCountValue = Convert.ToInt32(tbSampAdvPreAreaValue.Text);
            else jp.PresetCountValue = 0;
            if (!String.IsNullOrEmpty(tbSampAdvPreAreaChanFrom.Text))
                jp.PresetCountChanFrom = Convert.ToInt32(tbSampAdvPreAreaChanFrom.Text);
            else jp.PresetCountChanFrom = 0;
            if (!String.IsNullOrEmpty(tbSampAdvPreAreaChanTo.Text))
            {
                jp.PresetCountChanTo = Convert.ToInt32(tbSampAdvPreAreaChanTo.Text);
                if (jp.PresetCountChanTo > d.MaxChannels)
                {
                    MessageBox.Show("Maks antall kanaler for detektor (" + d.MaxChannels.ToString() + ") er lavere enn angitt i 'Chan. To' (" + jp.PresetCountChanTo.ToString() + ")");
                    return;
                }
                if (jp.PresetCountChanFrom > 0 && jp.PresetCountChanFrom >= jp.PresetCountChanTo)
                {
                    MessageBox.Show("'Chan. From' kan ikke være større enn 'Chan. To'");
                    return;
                }
            }
            else jp.PresetCountChanTo = 0;

            jp.PresetTime = cboxSampAdvPreTime.Text;
            if (!String.IsNullOrEmpty(jp.PresetTime))
            {
                if (tbSampAdvPreTimeValue.Text.Trim() == "0")
                {
                    MessageBox.Show("Kan ikke bruke 0 som verdi i kanaler eller tellere");
                    return;
                }
            }
            jp.PresetTimeUnit = cboxSampAdvPreTimeUnit.Text;
            if (!String.IsNullOrEmpty(tbSampAdvPreTimeValue.Text))
                jp.PresetTimeValue = Convert.ToInt32(tbSampAdvPreTimeValue.Text);
            else jp.PresetTimeValue = 0;
            if (jp.PresetTimeUnit == "Minutter")
                jp.PresetTimeValue *= 60;
            else if(jp.PresetTimeUnit == "Timer")
                jp.PresetTimeValue *= 3600;
            jp.SearchRegionFrom = d.SearchRegionFrom;
            jp.SearchRegionTo = d.SearchRegionTo;
            jp.Tolerance = Utils.ConvertToDouble(tbSampAnalTolerance.Text);
            jp.SignificanceThreshold = Utils.ConvertToDouble(tbSampAnalSigThresh.Text);
            jp.PeakAreaRegionFrom = d.PeakAreaRegionFrom;
            jp.PeakAreaRegionTo = d.PeakAreaRegionTo;
            jp.Continuum = Utils.ConvertToDouble(tbSampAnalContinuum.Text);
            jp.ContinuumFunction = cboxSampAnalContinuumFunc.Text;
            jp.CriticalLevel = cbSampAnalCritLev.Checked;
            jp.FitSinglets = cbSampAnalFitSinglets.Checked;
            jp.DisplayROIs = cbSampAnalDispRois.Checked;
            jp.UseFixedTailParameter = cbSampAnalUseFixed.Checked;
            jp.RejectZeroAreaPeaks = cbSampAnalRejectZero.Checked;
            jp.UseFixedFWHM = cbSampAnalFixedFWHM.Checked;

            jp.MaxFWHMSBetweenPeaks = Utils.ConvertToDouble(tbSampAnalMaxFWHMBetween.Text);
            jp.MaxFWHMSForLeftLimit = Utils.ConvertToDouble(tbSampAnalMaxFWHMLeft.Text);
            jp.MaxFWHMSForRightLimit = Utils.ConvertToDouble(tbSampAnalMaxFWHMRight.Text);
            jp.BackgroundSubtractFile = tbSampAnalBkgSub.Text;
            jp.EfficiencyCalibrationType = cboxSampAnalEffCal.Text;
            jp.NIDLibraryFile = tbSampAnalNIDLib.Text;
            jp.NIDConfidenceThreshold = Utils.ConvertToDouble(tbSampAnalNIDConfThresh.Text);
            jp.MDAConfidenceFactor = Utils.ConvertToDouble(tbSampAnalMDAConfFac.Text);
            jp.InhibitATDCorrection = cbSampAnalInhibitATD.Checked;
            jp.UseStoredLibrary = cbSampAnalUseStoredLib.Checked;
            jp.PerformMDATest = cbSampAnalPerformMDA.Checked;
            if (!String.IsNullOrEmpty(tbAdmSigma.Text))
                jp.Sigma = Convert.ToInt32(tbAdmSigma.Text);
            else jp.Sigma = 2;
            jp.ReportTemplateFile = tbAdmTemplate.Text;

            if (jp.Operation == "Bkg")
                jp.ReportSection = "HEADER";
            else if (jp.Operation == "Ref")
                jp.ReportSection = "HEADER";
            else
            {
                jp.ReportSection = cboxAdmSection.Text;
                if (jp.ReportSection == "ALL")
                    jp.ReportSection = "";
            }

            // Generer .BAT fil og kjør denne
            string cout;
            if (!isReanal)
            {
                string parFile = Config.JobDir + lblToolsDetector.Text + ".PAR";
                if (!GenerateBatFromParams(jp))
                    return;
                Utils.RunCommand(Config.JobDir + jp.DetectorName + ".BAT", "1>" + Config.JobDir + jp.DetectorName + ".OUT", out cout, false);
                // Lagre jobb parametere til fil
                Utils.SerializeJobParams(jp, parFile);
            }
            else
            {
                string tmpName = Config.TempDir + jp.SpecRef;
                string archiveName = gridArchive.SelectedRows[0].Cells["Base"].Value as String;

                GenerateReanalBatFromParams(tmpName, archiveName, jp);
                lblStatus.Text = "Reanalyserer spekter " + jp.SpecRef + ". Vennligst vent...";
                Application.DoEvents(); // Sørg for at lblStatus oppdateres umiddelbart

                Utils.RunCommand(tmpName + ".BAT", "1>" + tmpName + ".OUT", out cout, true);
                // Lagre jobb parametere til fil
                Utils.SerializeJobParams(jp, tmpName + ".PAR");

                // Vis rapport for reanalysering
                FormJobReport form = new FormJobReport(tmpName, archiveName, true, ref d, SysPar);
                form.ShowDialog();
            }

            tabs.SelectedTab = pageMenu;
        }

        /**        
         * Funksjon som genererer en .BAT fil som skal kjøres av Genie2k
         * 
         * @param   jp Data-struktur med parametere som skal benyttes i .BAT filen
         * 
         * @return  Sant hvis .BAT filen ble generert uten problemer, usant ellers
         */
        public bool GenerateBatFromParams(JobParams jp)
        {
            // Opprett .BAT fil for analysering og skriv inn kommandoer og parametere
            StreamWriter sw = new StreamWriter(Config.JobDir + jp.DetectorName + ".BAT", false, Encoding.GetEncoding(865));
            
            sw.Write("pars det:" + jp.DetectorName + " ");
            sw.Write("/stitle=\"" + jp.OrderName + "\" ");
            sw.Write("/scollname=\"" + jp.CollectorName + "\" ");
            sw.Write("/sdesc1=\"" + jp.Description + "\" ");
            sw.Write("/sdesc4=\"" + jp.SpecRef + "\" ");
            sw.Write("/sident=\"" + jp.SampleID + "\" ");
            sw.Write("/stype=\"" + jp.SampleType + "\" ");
            sw.Write("/squant=" + jp.SampleQuantity.ToString().Replace(',', '.') + " ");
            sw.Write("/squanterr=" + jp.SampleQuantityError.ToString().Replace(',', '.') + " ");
            sw.Write("/sunits=\"" + jp.SampleQuantityUnit + "\" ");
            sw.Write("/sgeomtry=\"" + jp.Geometry + "\" ");
            sw.Write("/builduptype=\"" + jp.BuildupType + "\" ");
            sw.Write("/stime=\"" + jp.BuildupStartDate.ToString() + "\" ");
            if (jp.BuildupType != "NONE")
                sw.Write("/sdeposit=\"" + jp.BuildupEndDate.ToString() + "\" ");
            sw.Write("/ssyserr=" + jp.RandomError.ToString().Replace(',', '.') + " ");
            sw.Write("/ssysterr=" + jp.SystematicError.ToString().Replace(',', '.') + Environment.NewLine);

            if (jp.Operation != "Bkg")
                sw.Write("movedata \"" + jp.CalibrationFile + "\" det:" + jp.DetectorName + " /effcal /overwrite" + Environment.NewLine);

            sw.Write("startmca det:" + jp.DetectorName + " ");
            if (!String.IsNullOrEmpty(jp.PresetCount))
                sw.Write("/" + jp.PresetCount + "=" + jp.PresetCountValue.ToString() + "," + jp.PresetCountChanFrom.ToString() + "," + jp.PresetCountChanTo.ToString() + " ");
            if (!String.IsNullOrEmpty(jp.PresetTime))
                sw.Write("/" + jp.PresetTime + "=" + jp.PresetTimeValue.ToString());
            sw.WriteLine();

            sw.WriteLine("wait det:" + jp.DetectorName + " /acq");

            sw.WriteLine("peak_dif det:" + jp.DetectorName + " /channels=" + jp.SearchRegionFrom.ToString() + "," + jp.SearchRegionTo.ToString() + " /signif=" + jp.SignificanceThreshold.ToString().Replace(',', '.') + " /ftol=" + jp.Tolerance.ToString().Replace(',', '.'));
            sw.Write("area_nl1 det:" + jp.DetectorName + " /channels=" + jp.PeakAreaRegionFrom.ToString() + "," + jp.PeakAreaRegionTo.ToString() + " ");
            sw.Write("/fcont=" + jp.Continuum.ToString().Replace(',', '.') + " ");
            if (jp.CriticalLevel)
                sw.Write("/critlevel ");
            if (jp.FitSinglets)
                sw.Write("/fit ");
            if (jp.DisplayROIs)
                sw.Write("/display_rois ");
            if (jp.UseFixedTailParameter)
                sw.Write("/fixtail ");
            if (jp.UseFixedFWHM)
                sw.Write("/fixfwhm ");
            sw.WriteLine();

            sw.Write("pars det:" + jp.DetectorName + " /roipsbtyp=\"" + jp.ContinuumFunction + "\" /prreject0pks=" + (jp.RejectZeroAreaPeaks ? "1" : "0") + " /prfwhmpkmult=" + jp.MaxFWHMSBetweenPeaks.ToString().Replace(',', '.') + " ");
            sw.WriteLine("/prfwhmpkleft=" + jp.MaxFWHMSForLeftLimit.ToString().Replace(',', '.') + " /prfwhmpkrght=" + jp.MaxFWHMSForRightLimit.ToString().Replace(',', '.'));

            if (jp.Operation != "Bkg")
            {
                sw.WriteLine("areacor det:" + jp.DetectorName + " /bkgnd=\"" + jp.BackgroundSubtractFile + "\"");
                sw.WriteLine("effcor det:" + jp.DetectorName + " /" + jp.EfficiencyCalibrationType);
                sw.Write("nid_intf det:" + jp.DetectorName + " /library=\"" + jp.NIDLibraryFile + "\" /confid=" + jp.NIDConfidenceThreshold.ToString().Replace(',', '.') + " ");
                if (jp.PerformMDATest)
                    sw.Write("/mda_test ");
                if (jp.InhibitATDCorrection)
                    sw.Write("/noacqdecay ");
                sw.WriteLine();

                sw.WriteLine("pars det:" + jp.DetectorName + " /prusestrlib=" + (jp.UseStoredLibrary ? "1" : "0") + " /mdaconfid=" + jp.MDAConfidenceFactor);

                sw.WriteLine("MDA det:" + jp.DetectorName);
                sw.WriteLine("pars det:" + jp.DetectorName + " /activunits=\"Bq\" /activmult=37000");
            }
            sw.WriteLine("report det:" + jp.DetectorName + " /template=\"" + jp.ReportTemplateFile + "\" /newfile /firstpg /newpg /outfile=\"" + Config.JobDir + jp.DetectorName + ".RPT\" /section=\"" + jp.ReportSection + "\" /EM=" + jp.Sigma.ToString());
            sw.WriteLine("movedata det:" + jp.DetectorName + " \"" + Config.JobDir + jp.DetectorName + ".CNF\" /overwrite");

            if (jp.Operation == "Bkg")
            {
                string qafFile = Config.QADir + jp.DetectorName + "-BKG.QAF";
                if(!File.Exists(qafFile))
                    File.Copy(Config.DefaultBkgQAFFile, qafFile, true);
                sw.WriteLine("qaxfer det:" + jp.DetectorName + " \"" + qafFile + "\"");
                //sw.WriteLine("qaanalyz \"" + qafFile + "\" /REPORT=LAST /SAMPLE /SCREEN 1>>\"" + Config.JobDir + jp.DetectorName + ".RPT\"");
                sw.WriteLine("qaanalyz \"" + qafFile + "\" /REPORT=LAST /SCREEN 1>>\"" + Config.JobDir + jp.DetectorName + ".RPT\"");
            }
            else if (jp.Operation == "Ref")
            {
                Detector d = getDetectorByName(jp.DetectorName);
                string qabox = getQABoxFromDetector(d, jp.Geometry);
                string qafFile = Config.QADir + jp.DetectorName + "-" + jp.Geometry + "-" + qabox + ".QAF";
                /*if (!File.Exists(qafFile))
                {
                    string defQafFile = Config.ScintilabDir + "DEFAULT-" + qabox + ".QAF";
                    if (!File.Exists(defQafFile))
                    {
                        sw.Close();
                        MessageBox.Show("Mangler default QA fil " + defQafFile);
                        return false;
                    }
                    File.Copy(defQafFile, qafFile, true);
                }*/
                sw.WriteLine("qaxfer det:" + jp.DetectorName + " \"" + qafFile + "\"");
                sw.WriteLine("qaanalyz \"" + qafFile + "\" /REPORT=LAST /SCREEN 1>>\"" + Config.JobDir + jp.DetectorName + ".RPT\"");
            }
            
            sw.Close();
            return true;
        }

        /**        
         * Funksjon som genererer en .BAT fil for reanalysering som skal kjøres av Genie2k
         * 
         * @param   tempName Filbane (uten ending) hvor filer skal genereres
         * @param   archiveName Filbane (uten ending) hvor tidligere filer hentes fra
         * @param   jp Data-struktur med parametere som skal benyttes i .BAT filen
         */
        public void GenerateReanalBatFromParams(string tempName, string archiveName, JobParams jp)
        {
            // Opprett .BAT fil for reanalysering og skriv inn kommandoer og parametere
            StreamWriter sw = new StreamWriter(tempName + ".BAT", false, Encoding.GetEncoding(865));
            
            string cnfFile = archiveName + ".CNF";
            string tmpCnfFile = tempName + ".CNF";
            File.Copy(cnfFile, tmpCnfFile, true);

            sw.Write("pars " + tmpCnfFile + " ");
            sw.Write("/stitle=\"" + jp.OrderName + "\" ");
            sw.Write("/scollname=\"" + jp.CollectorName + "\" ");
            sw.Write("/sdesc1=\"" + jp.Description + "\" ");
            sw.Write("/sdesc4=\"" + jp.SpecRef + "\" ");
            sw.Write("/sident=\"" + jp.SampleID + "\" ");
            sw.Write("/stype=\"" + jp.SampleType + "\" ");
            sw.Write("/squant=" + jp.SampleQuantity.ToString().Replace(',', '.') + " ");
            sw.Write("/squanterr=" + jp.SampleQuantityError.ToString().Replace(',', '.') + " ");
            sw.Write("/sunits=\"" + jp.SampleQuantityUnit + "\" ");
            sw.Write("/sgeomtry=\"" + jp.Geometry + "\" ");
            sw.Write("/builduptype=\"" + jp.BuildupType + "\" ");
            sw.Write("/stime=\"" + jp.BuildupStartDate.ToString() + "\" ");
            if (jp.BuildupType != "NONE")
                sw.Write("/sdeposit=\"" + jp.BuildupEndDate.ToString() + "\" ");
            sw.Write("/ssyserr=" + jp.RandomError.ToString().Replace(',', '.') + " ");
            sw.Write("/ssysterr=" + jp.SystematicError.ToString().Replace(',', '.') + Environment.NewLine);
            
            sw.Write("movedata \"" + jp.CalibrationFile + "\" " + tmpCnfFile + " /effcal /overwrite" + Environment.NewLine);

            sw.WriteLine("peak_dif " + tmpCnfFile + " /channels=" + jp.SearchRegionFrom.ToString() + "," + jp.SearchRegionTo.ToString() + " /signif=" + jp.SignificanceThreshold.ToString().Replace(',', '.') + " /ftol=" + jp.Tolerance.ToString().Replace(',', '.'));
            sw.Write("area_nl1 " + tmpCnfFile + " /channels=" + jp.PeakAreaRegionFrom.ToString() + "," + jp.PeakAreaRegionTo.ToString() + " ");
            sw.Write("/fcont=" + jp.Continuum.ToString().Replace(',', '.') + " ");
            if (jp.CriticalLevel)
                sw.Write("/critlevel ");
            if (jp.FitSinglets)
                sw.Write("/fit ");
            if (jp.DisplayROIs)
                sw.Write("/display_rois ");
            if (jp.UseFixedTailParameter)
                sw.Write("/fixtail ");
            if (jp.UseFixedFWHM)
                sw.Write("/fixfwhm ");
            sw.WriteLine();

            sw.Write("pars " + tmpCnfFile + " /roipsbtyp=\"" + jp.ContinuumFunction + "\" /prreject0pks=" + (jp.RejectZeroAreaPeaks ? "1" : "0") + " /prfwhmpkmult=" + jp.MaxFWHMSBetweenPeaks.ToString().Replace(',', '.') + " ");
            sw.WriteLine("/prfwhmpkleft=" + jp.MaxFWHMSForLeftLimit.ToString().Replace(',', '.') + " /prfwhmpkrght=" + jp.MaxFWHMSForRightLimit.ToString().Replace(',', '.'));

            sw.WriteLine("areacor " + tmpCnfFile + " /bkgnd=\"" + jp.BackgroundSubtractFile + "\"");
            sw.WriteLine("effcor " + tmpCnfFile + " /" + jp.EfficiencyCalibrationType);
            sw.Write("nid_intf " + tmpCnfFile + " /library=\"" + jp.NIDLibraryFile + "\" /confid=" + jp.NIDConfidenceThreshold.ToString().Replace(',', '.') + " ");
            if (jp.PerformMDATest)
                sw.Write("/mda_test ");
            if (jp.InhibitATDCorrection)
                sw.Write("/noacqdecay ");
            sw.WriteLine();

            sw.WriteLine("pars " + tmpCnfFile + " /prusestrlib=" + (jp.UseStoredLibrary ? "1" : "0") + " /mdaconfid=" + jp.MDAConfidenceFactor);

            sw.WriteLine("MDA " + tmpCnfFile);
            sw.WriteLine("pars " + tmpCnfFile + " /activunits=\"Bq\" /activmult=37000");

            sw.WriteLine("report " + tmpCnfFile + " /template=\"" + jp.ReportTemplateFile + "\" /newfile /firstpg /newpg /outfile=\"" + Config.TempDir + jp.SpecRef + ".RPT\" /section=\"" + jp.ReportSection + "\" /EM=" + jp.Sigma.ToString());
            
            sw.Close();
        }

        /**        
         * Funksjon som henter navn på QA-beger fra detektor
         * 
         * @param   d Detektor det skal hentes fra
         * @param   geom Beger det skal hentes fra         
         * 
         * @return  Navn på QA-beger funnet, eller tom streng hvis QA-beger ikke ble funnet
         */
        private string getQABoxFromDetector(Detector d, string geom)
        {
            // Gå gjennom alle QA-begere definert for valgt detektor
            foreach (BeakerInfo bi in d.BeakerInfoList)
            {
                // Returner navn på QA-beger hvis funnet
                if (bi.BeakerName.ToUpper() == geom.ToUpper())
                {
                    return bi.QAName;
                }
            }
            return null;
        }

        /**        
         * Hendelse som viser et spekter i Genie2k fra jobb-oversikten         
         */
        private void btnJobOpenSpectrum_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen jobb er valgt
            if (gridJobs.SelectedRows.Count == 0)
                return;

            // Hent detektornavn fra grensesnitt
            string det = gridJobs.SelectedRows[0].Cells["Detector"].Value as String;

            // Kjør "endview" i tilfelle et view er åpent allerede
            string cout;
            Utils.RunCommand("endview.exe", "", out cout, true);

            // Kjør putview for valgt detektor
            Process.Start("putview.exe", "det:" + det);
        }

        /**        
         * Hendelse som viser en "standard output" fil fra jobb-oversikten         
         */
        private void btnJobsShowOutput_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen jobb er valgt
            if (gridJobs.SelectedRows.Count == 0)
                return;

            // Hent detektornavn fra grensesnitt
            string det = gridJobs.SelectedRows[0].Cells["Detector"].Value as String;
            // Vis .OUT filen i notepad hvis filen finnes
            string outFile = Config.JobDir + det + ".OUT";
            if (File.Exists(outFile))
                Process.Start("notepad.exe", outFile);
            else
                MessageBox.Show("Filen " + outFile + " ble ikke funnet");
        }

        /**        
         * Hendelse for valg av Genie2k katalog under administrasjonssidene
         */
        private void btnAdmGenieFolder_Click(object sender, EventArgs e)
        {
            string genieFolder = getFolder("Velg Genie katalog");
            if(!String.IsNullOrEmpty(genieFolder))
                tbAdmGenieFolder.Text = genieFolder;
        }

        /**        
         * Hendelse for lagring av generelle innstillinger under administrasjonssidene
         */
        private void btnAdmSave_Click(object sender, EventArgs e)
        {
            // Sjekk at påkrevde felter er fyllt inn
            if (String.IsNullOrEmpty(tbAdmGenieFolder.Text) 
                || String.IsNullOrEmpty(tbAdmSigma.Text)
                || String.IsNullOrEmpty(tbAdmTemplate.Text)
                || String.IsNullOrEmpty(tbAdmLIMSImport.Text)
                || String.IsNullOrEmpty(tbAdmLIMSExport.Text)
                || String.IsNullOrEmpty(cboxAdmSection.Text)
                || String.IsNullOrEmpty(cboxAdmPlotScaleY.Text)
                || String.IsNullOrEmpty(cboxAdmPlotScaleX.Text))
            {
                MessageBox.Show("En eller fler påkrevde felter mangler under Generelle innstillinger");
                return;
            }

            // Sjekk at Genie2k katalogbanen er gyldig
            if (!Utils.ValidateGeniePath(SysPar, tbAdmGenieFolder.Text))
                return;

            tbAdmGenieFolder.Text = SysPar.GenieDirectory;

            int sig = Convert.ToInt32(tbAdmSigma.Text);
            if (sig < 1 || sig > 3)
            {
                MessageBox.Show("Sigma kan ikke være under 1 eller over 3");
                return;
            }

            // Fyll syspar datastrukturen med verdier fra feltene
            SysPar.GenieDirectory = tbAdmGenieFolder.Text;
            SysPar.ErrorMultiplier = Convert.ToInt32(tbAdmSigma.Text);
            SysPar.ReportTemplate = tbAdmTemplate.Text;
            SysPar.ReportSection = cboxAdmSection.Text;
            SysPar.ReportScaleY = cboxAdmPlotScaleY.Text;
            SysPar.ReportScaleX = cboxAdmPlotScaleX.Text;
            SysPar.LimsImport = tbAdmLIMSImport.Text;
            SysPar.LimsExport = tbAdmLIMSExport.Text;

            // Lagre syspar datastrukturen tilbake til fil
            Utils.SerializeSysPar(SysPar);

            // Logg aktivitet
            Config.LogMessage("Admin General lagret");
        }

        /**        
         * Hendelse for valg av template fil under administrasjonssidene
         */
        private void btnAdmTemplate_Click(object sender, EventArgs e)
        {
            string fname = getFile("Velg template fil", Config.TemplateDir, "Template fil (*.TPL)|*.TPL");
            if (!String.IsNullOrEmpty(fname))
                tbAdmTemplate.Text = fname;
        }

        /**        
         * Hendelse for valg av LIMS import katalog under administrasjonssidene
         */
        private void btnAdmLIMSImport_Click(object sender, EventArgs e)
        {
            string LIMSImportFolder = getFolder("Velg LIMS import katalog");
            if (!String.IsNullOrEmpty(LIMSImportFolder))
                tbAdmLIMSImport.Text = LIMSImportFolder;
        }

        /**        
         * Hendelse for valg av LIMS eksport katalog under administrasjonssidene
         */
        private void btnAdmLIMSExport_Click(object sender, EventArgs e)
        {
            string LIMSExportFolder = getFolder("Velg LIMS eksport katalog");
            if (!String.IsNullOrEmpty(LIMSExportFolder))
                tbAdmLIMSExport.Text = LIMSExportFolder;
        }

        /**        
         * Hendelse for sletting av detektor, beger, cal kobling under administrasjonssidene
         */
        private void btnAdmDetGeomCalDelete_Click(object sender, EventArgs e)
        {
            // Avbryt hvis det/cal/QA kombinasjon ikke er valgt
            if (gridAdmDetGeomCalQA.SelectedCells.Count == 0)
                return;

            // Hent beger og detektor fra grensesnitt
            string geom = gridAdmDetGeomCalQA.SelectedCells[0].Value as String;
            Detector d = getDetectorByName(lbAdmDetList.SelectedItem.ToString());

            // Fjern det/cal/QA kombinasjon fra detektor hvis den finnes
            foreach (BeakerInfo bi in d.BeakerInfoList)
            {
                if (bi.BeakerName.ToUpper() == geom.ToUpper())
                {
                    d.BeakerInfoList.Remove(bi);
                    break;
                }
            }

            // Oppdater grensesnitt for det/cal/QA kombinasjoner
            gridAdmDetGeomCalQA.Rows.Clear();
            for (int j = 0; j < d.BeakerInfoList.Count; j++)
            {
                BeakerInfo bi = d.BeakerInfoList[j];
                gridAdmDetGeomCalQA.Rows.Add(bi.BeakerName, bi.CalibrationFile, bi.QAName);
            }
        }

        /**        
         * Hendelse for skifte av kategori under arkivet
         */
        private void tvArchive_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0) // Detektorer
            {
                // Opprett en årstall node for hver katalog som finnes under denne detektor katalogen
                string selectedDir = e.Node.Text;
                e.Node.Nodes.Clear();
                gridArchive.Rows.Clear();
                char[] seps = { Path.DirectorySeparatorChar };
                string[] dirs = Directory.GetDirectories(Config.ArchiveDir + Path.DirectorySeparatorChar + selectedDir);
                foreach (string dir in dirs)
                {
                    string[] pathItems = dir.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    TreeNode tn = new TreeNode(pathItems[pathItems.Length - 1]);
                    e.Node.Nodes.Add(tn);
                }
            }
            else if (e.Node.Level == 1) // Årstall
            {
                // Fyll inn alle analyseresultater i arkivlista
                string yearDir = e.Node.Text;
                string detDir = e.Node.Parent.Text;
                string[] files = Directory.GetFiles(Config.ArchiveDir + detDir + Path.DirectorySeparatorChar + yearDir, "*.CNF");
                char[] seps = { '-' };
                gridArchive.Rows.Clear();
                foreach (string file in files)
                {
                    string baseName = file.Substring(0, file.Length - 4);

                    string[] items = Path.GetFileNameWithoutExtension(file).Split(seps);
                    int ant = items.Length;
                    if (items[2] == "Sample") // FIXME
                        items[2] = "Prøve";

                    string fn = Path.GetFileName(file);
                    int pos1 = fn.IndexOf('-');
                    int pos2 = fn.LastIndexOf('-');
                    string tmp = fn.Substring(pos1, pos2 - pos1);
                    pos2 = tmp.LastIndexOf('-');
                    tmp = tmp.Substring(0, pos2);

                    gridArchive.Rows.Add(items[0], tmp.Substring(1, tmp.Length-1), items[ant-2], items[ant-1], baseName);
                }
            }
        }

        /**        
         * Hendelse for oppretting av nytt QA-beger under administrasjonssidene
         */
        private void btnAdmQANew_Click(object sender, EventArgs e)
        {
            // Vis vindu for nytt QA-beger
            FormInputName form = new FormInputName("Velg et navn");
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Sjekk at valgt navn er gyldig
                if(!Utils.ValidName(form.SelectedName))
                {
                    MessageBox.Show("Uglyldig tegn i navnet. Bruk kun tall, bokstaver og bindestrek");
                    return;
                }

                // Opprett QA-beger datastruktur og legg den til i lista over QA-begere
                QABeaker newBeaker = new QABeaker();
                newBeaker.Name = form.SelectedName;
                newBeaker.RefDate = DateTime.Now;
                newBeaker.InUse = false;
                QABeakers.Add(newBeaker);

                // Oppdater grensesnitt
                lbAdmQAList.Items.Clear();
                for (int i = 0; i < QABeakers.Count(); i++)
                    lbAdmQAList.Items.Add(QABeakers[i].Name);

                MessageBox.Show("Husk å konfigurere QA boks " + newBeaker.Name);
            }
        }

        /**        
         * Hendelse for reanalysering under arkivet
         */
        private void btnArchiveReanal_Click(object sender, EventArgs e)
        {
            try
            {
                // Avbryt hvis ingen analyse er valgt
                if (gridArchive.SelectedRows.Count == 0)
                    return;

                // Hent navn fra grensesnittet
                string specRef = gridArchive.SelectedRows[0].Cells["SpecRef"].Value as String;
                string sampId = gridArchive.SelectedRows[0].Cells["SampleID"].Value as String;
                string operation = gridArchive.SelectedRows[0].Cells["Operation"].Value as String;
                string collector = gridArchive.SelectedRows[0].Cells["Collector"].Value as String;

                if (operation != "Prøve")
                {
                    MessageBox.Show("Kan ikke reanalysere en " + operation + " måling");
                    return;
                }
                operation = "Sample";

                // Gjenskap .PAR filnavn
                string det = specRef.Substring(0, 2);
                string year = "20" + specRef.Substring(2, 2);
                string parFile = Config.ArchiveDir + det + Path.DirectorySeparatorChar + year + Path.DirectorySeparatorChar + specRef + "-" + sampId + "-" + operation + "-" + collector + ".PAR";
                // Sjekk at .PAR fil finnes
                if (!File.Exists(parFile))
                {
                    MessageBox.Show("Finner ikke filen " + parFile);
                    return;
                }

                // Fyll inn felter under prøve info
                isReanal = true;
                SelInfo.Init();
                SelInfo.AnalType = "Sample";
                
                SetSampleFieldsStatus(true);
                cboxSampAdvPreArea.Enabled = false;
                tbSampAdvPreAreaValue.Enabled = false;
                tbSampAdvPreAreaChanFrom.Enabled = false;
                tbSampAdvPreAreaChanTo.Enabled = false;
                cboxSampAdvPreTime.Enabled = false;
                tbSampAdvPreTimeValue.Enabled = false;
                cboxSampAdvPreTimeUnit.Enabled = false;

                clearSampParams();

                populateSampGeom(det);

                // Fyll inn felter fra datastruktur med jobb parametere
                JobParams jp = Utils.DeserializeJobParams(parFile);

                lblToolsDetector.Text = det;
                tbSampOrder.Text = jp.OrderName;
                tbSampDesc.Text = jp.Description;
                tbSampID.Text = jp.SampleID;
                tbSampType.Text = jp.SampleType;
                cboxSampGeom.Text = jp.Geometry; // FIXME: Beaker kan være utilgjengelig
                tbSampQuant.Text = jp.SampleQuantity.ToString();
                cboxSampQuantUnit.Text = jp.SampleQuantityUnit;
                tbSampQuantUnc.Text = jp.SampleQuantityError.ToString();
                tbSampRef.Text = jp.SpecRef;
                tbSampCollector.Text = jp.CollectorName;
                tbSampComment.Text = jp.Comment;
                cboxSampAdvCal.Text = Path.GetFileName(jp.CalibrationFile);
                tbSampAdvRandErr.Text = jp.RandomError.ToString();
                tbSampAdvSystErr.Text = jp.SystematicError.ToString();
                cboxSampAdvPreArea.Text = jp.PresetCount;
                tbSampAdvPreAreaValue.Text = jp.PresetCountValue.ToString();
                tbSampAdvPreAreaChanFrom.Text = jp.PresetCountChanFrom.ToString();
                tbSampAdvPreAreaChanTo.Text = jp.PresetCountChanTo.ToString();
                cboxSampAdvPreTime.Text = jp.PresetTime;
                tbSampAdvPreTimeValue.Text = jp.PresetTimeValue.ToString();
                cboxSampAdvPreTimeUnit.Text = jp.PresetTimeUnit;

                tbSampAnalTolerance.Text = jp.Tolerance.ToString();
                tbSampAnalSigThresh.Text = jp.SignificanceThreshold.ToString();
                tbSampAnalContinuum.Text = jp.Continuum.ToString();
                cboxSampAnalContinuumFunc.Text = jp.ContinuumFunction;
                cbSampAnalCritLev.Checked = jp.CriticalLevel;
                cbSampAnalFitSinglets.Checked = jp.FitSinglets;
                cbSampAnalDispRois.Checked = jp.DisplayROIs;
                cbSampAnalUseFixed.Checked = jp.UseFixedTailParameter;
                cbSampAnalRejectZero.Checked = jp.RejectZeroAreaPeaks;
                cbSampAnalFixedFWHM.Checked = jp.UseFixedFWHM;
                cboxSampAnalEffCal.Text = jp.EfficiencyCalibrationType;
                tbSampAnalMaxFWHMBetween.Text = jp.MaxFWHMSBetweenPeaks.ToString();
                tbSampAnalMaxFWHMLeft.Text = jp.MaxFWHMSForRightLimit.ToString();
                tbSampAnalMaxFWHMRight.Text = jp.MaxFWHMSForRightLimit.ToString();
                tbSampAnalBkgSub.Text = jp.BackgroundSubtractFile;
                tbSampAnalNIDLib.Text = jp.NIDLibraryFile;
                tbSampAnalNIDConfThresh.Text = jp.NIDConfidenceThreshold.ToString();
                tbSampAnalMDAConfFac.Text = jp.MDAConfidenceFactor.ToString();
                cbSampAnalInhibitATD.Checked = jp.InhibitATDCorrection;
                cbSampAnalUseStoredLib.Checked = jp.UseStoredLibrary;
                cbSampAnalPerformMDA.Checked = jp.PerformMDATest;

                if (jp.BuildupType == "NONE")
                    tabsBuildup.SelectedTab = tabBuildupNone;
                else if (jp.BuildupType == "IRRAD")
                    tabsBuildup.SelectedTab = tabBuildupIrrad;
                else tabsBuildup.SelectedTab = tabBuildupDeposit;
                dtSampBuildNoneDate.Value = jp.BuildupStartDate;
                dtSampBuildNoneTime.Value = jp.BuildupStartDate;
                dtSampBuildIrradDateFrom.Value = jp.BuildupStartDate;
                dtSampBuildIrradTimeFrom.Value = jp.BuildupStartDate;
                dtSampBuildIrradDateTo.Value = jp.BuildupEndDate;
                dtSampBuildIrradTimeTo.Value = jp.BuildupEndDate;
                dtSampBuildDepDateFrom.Value = jp.BuildupStartDate;
                dtSampBuildDepTimeFrom.Value = jp.BuildupStartDate;
                dtSampBuildDepDateTo.Value = jp.BuildupEndDate;
                dtSampBuildDepTimeTo.Value = jp.BuildupEndDate;

                cboxSampAdvPreArea.Enabled = false;
                tbSampAdvPreAreaValue.Enabled = false;
                tbSampAdvPreAreaChanFrom.Enabled = false;
                tbSampAdvPreAreaChanTo.Enabled = false;
                cboxSampAdvPreTime.Enabled = false;
                tbSampAdvPreTimeValue.Enabled = false;
                cboxSampAdvPreTimeUnit.Enabled = false;
                
                tabs.SelectedTab = pageSample;
                tabsSamples.SelectedTab = tabSamplesParams;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**        
         * Hendelse for å vise QA-plott under arkivet
         */
        private void btnOpenQAPlot_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen rad er merket
            if (gridArchive.SelectedRows.Count == 0)
                return;

            // Hent ut verdier fra grensesnittet
            string cout;
            string operation = gridArchive.SelectedRows[0].Cells["Operation"].Value as String;
            string specRef = gridArchive.SelectedRows[0].Cells["SpecRef"].Value as String;
            string det = specRef.Substring(0, 2);

            if (operation == "Prøve")
            {
                MessageBox.Show("Du må velge en bakgrunn eller referansemåling");
                return;
            }
            else if (operation == "Ref")
            {
                string parFile = gridArchive.SelectedRows[0].Cells["Base"].Value as String;
                string sampid = gridArchive.SelectedRows[0].Cells["SampleID"].Value as String;
                parFile += ".PAR";
                // Les inn jobb parametere fra fil
                JobParams jp = Utils.DeserializeJobParams(parFile);
                string qaFile = Config.QADir + det + "-" + jp.Geometry + "-" + sampid + ".QAF";
                if (!File.Exists(qaFile))
                {
                    MessageBox.Show("QA filen " + qaFile + " finnes ikke");
                    return;
                }
                // Kjør QA commando
                Utils.RunCommand("QA", qaFile, out cout, false);
            }
            else
            {
                string filename = Config.QADir + det + "-BKG.QAF";
                if (!File.Exists(filename))
                {
                    MessageBox.Show("Finner ikke filen " + filename);
                    return;
                }
                // Kjør QA commando
                Utils.RunCommand("QA", filename, out cout, false);
            }
        }

        /**        
         * Hendelse for å vise resultat av en jobb som er ferdig men ikke godkjent
         */
        private void btnJobShow_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen rad er merket
            if (gridJobs.SelectedRows.Count == 0)
                return;

            // Hent verdier fra grensesnitt
            string status = gridJobs.SelectedRows[0].Cells["JobStatus"].Value as String;
            if (status.ToUpper() != "FERDIG")
            {
                lblStatus.Text = "Jobben er ikke ferdig";
                return;
            }
            string det = gridJobs.SelectedRows[0].Cells["Detector"].Value as String;
            Detector d = getDetectorByName(det);

            // Vis vindu for godkjenning av jobb
            FormJobReport form = new FormJobReport(Config.JobDir + det, "", false, ref d, SysPar);
            form.ShowDialog();
            if (form.UpdateDetectors)
                Utils.SerializeDetectors(Detectors);
        }

        /**        
         * Hendelse for å velge bakgrunnsfil under prøveinfo
         */
        private void btnSampAnalBkgSub_Click(object sender, EventArgs e)
        {
            string filter = "Bakgrunnsfiler|" + lblToolsDetector.Text + "*.CNF";
            string bkgfile = getFile("Velg bakgrunnsfil", Config.BkgDir, filter);
            if (!String.IsNullOrEmpty(bkgfile))
                tbSampAnalBkgSub.Text = bkgfile;
        }

        /**        
         * Hendelse for å velge NID bibliotek under prøveinfo
         */
        private void btnSampAnalNIDLib_Click(object sender, EventArgs e)
        {
            string nlbfile = getFile("Velg NID Bibliotek", Config.LibDir, "NID Bibliotek|*.NLB");
            if (!String.IsNullOrEmpty(nlbfile))
                tbSampAnalNIDLib.Text = nlbfile;
        }

        /**        
         * Hendelse for å vise et resultat under arkivet
         */
        private void btnArchiveShowReport_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen rad er valgt
            if (gridArchive.SelectedRows.Count == 0)
                return;

            // Hent verdier fra grensesnittet
            string baseName = gridArchive.SelectedRows[0].Cells["Base"].Value as String;
            string rptFile = baseName + ".RPT";
            // Vis vindu med rapporten
            FormQuickView form = new FormQuickView(File.ReadAllText(rptFile, Encoding.GetEncoding(1252)));
            form.ShowDialog();
        }

        /**        
         * Hendelse for å vise parametere for et resultat under arkivet
         */
        private void btnArchiveShowParams_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen rad er valgt
            if (gridArchive.SelectedRows.Count == 0)
                return;

            // Hent verdier fra grensesnittet
            string baseName = gridArchive.SelectedRows[0].Cells["Base"].Value as String;
            string parFile = baseName + ".PAR";
            // Vis vindu med parametere
            FormQuickView form = new FormQuickView(File.ReadAllText(parFile));
            form.ShowDialog();
        }

        /**        
         * Hendelse for å skrive ut et resultat under arkivet
         */
        private void btnArchivePrint_Click(object sender, EventArgs e)
        {
            // Avbryt hvis ingen rad er valgt
            if (gridArchive.SelectedRows.Count == 0)
                return;

            // Hent verdier fra grensesnittet
            string baseName = gridArchive.SelectedRows[0].Cells["Base"].Value as String;
            string rptFile = baseName + ".RPT";
            string cnfFile = baseName + ".CNF";

            // Opprett og initisier objekter for printing
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            MultipadPrintDocument printDoc = new MultipadPrintDocument();

            printDoc.PrinterSettings = pd.PrinterSettings;
            printDoc.Font = new Font("Courier New", 9, FontStyle.Regular);
            printDoc.Text = File.ReadAllText(rptFile, Encoding.UTF8);
            // Print rapporten
            printDoc.Print();

            // Print plott
            string cout;
            Utils.RunCommand("DATAPLOT", cnfFile + " /SCALE=" + SysPar.ReportScaleY + " /XSCALE=" + SysPar.ReportScaleX + " /ENHPLOT", out cout, false);
        }

        /**        
         * Hendelse for å logge ut av Scintilab
         */
        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            // Tøm felter for bruker
            tabs.SelectedTab = pageMenu;
            lblStatusUsername.Text = "";

            // Vis vindu for innlogging
            FormLogin form = new FormLogin(SysPar.UseActiveDirectory);
            form.ShowDialog();
            if (form.DialogResult != System.Windows.Forms.DialogResult.OK)
                Close(); // Avslutt Scintilab

            SysPar.UseActiveDirectory = form.UseActiveDirectory;

            // Sett felter for bruker (har logget inn)
            Config.Username = form.Username;
            lblStatusUsername.Text = Config.Username;
        }

        /**        
         * Funksjon for å sjekke om et tegn er et gyldig hel-tall
         * 
         * @return  Sant hvis tegnet er et tall, usant ellers
         */
        bool checkValidInteger(char ch)
        {
            if ((ch >= '0' && ch <= '9') || ch == '\b')
                return true;

            return false;
        }

        /**        
         * Funksjon for å sjekke om kombinasjonen av en streng og et tegn gir et gyldig desimal-tall
         * 
         * @param   txt Streng som skal valideres
         * @param   ch Tegn som skal legges til txt
         * 
         * @return  Sant hvis resultatet er et gyldig desimal-tall, usant ellers
         */
        bool checkValidDecimal(string txt, char ch)
        {            
            bool hasPeriod = false;
            foreach (char c in txt)
                if (c == '.' || c == ',')
                    hasPeriod = true;

            if (ch.ToString() == Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator)
            {
                MessageBox.Show("Karakteren '" + ch + "' er gruppe separator på systemet du sitter på");
                return false;
            }

            if ((ch == '.' || ch == ',') && !hasPeriod)
                return true;

            if ((ch >= '0' && ch <= '9') || ch == '\b')
                return true;

            return false;
        }

        /**        
         * Hendelse for validere inntasting av hel-tall         
         */
        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkValidInteger(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        /**        
         * Hendelse for å validere inntasting av desimal-tall         
         */
        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if(!checkValidDecimal(text, e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        /**        
         * Hendelse for lagring av QA-beger på administrasjonssidene
         */
        private void btnAdmQASave_Click(object sender, EventArgs e)
        {
            if (lbAdmQAList.SelectedItems.Count == 0)
                return;

            string qaGeom = lbAdmQAList.SelectedItems[0] as String;
            QABeaker qab = getQABeakerByName(qaGeom);
            qab.InUse = cbAdmQAInUse.Checked;
            qab.BeakerName = cboxAdmQABeaker.Text;

            string dtstr = dtAdmQARefDate.Value.ToShortDateString() + " " + dtAdmQARefTime.Value.ToLongTimeString();
            qab.RefDate = DateTime.Parse(dtstr);
            qab.SampleType = tbAdmQASampType.Text;
            qab.SampleQuantity = Utils.ConvertToDouble(tbAdmQASampQuant.Text);
            qab.Unit = cboxAdmQASampUnit.Text;
            qab.Uncertainty = Utils.ConvertToDouble(tbAdmQASampUnc.Text);
            Utils.SerializeQABeakers(QABeakers);
            // Logg aktivitet
            Config.LogMessage("Admin QA-geometrier lagret");
            lblStatus.Text = "QA boks " + qaGeom + " ble lagret";
        }

        /**        
         * Hendelse for lagring av beger på administrasjonssidene
         */
        private void btnAdmGeomSave_Click(object sender, EventArgs e)
        {
            if (lbAdmGeomList.SelectedItems.Count == 0)
                return;

            string geom = lbAdmGeomList.SelectedItems[0] as String;
            Beaker b = getBeakerByName(geom);
            b.Manufacturer = tbAdmGeomManufacturer.Text;
            b.InUse = cbAdmGeomInUse.Checked;
            Utils.SerializeBeakers(Beakers);
            // Logg aktivitet
            Config.LogMessage("Admin Geometrier lagret");
            lblStatus.Text = "Geometri " + geom + " ble lagret";

            cboxAdmQABeaker.Items.Clear();
            Beakers = Utils.DeserializeBeakers();
            for (int i = 0; i < Beakers.Count(); i++)
            {
                //if (Beakers[i].InUse)
                    cboxAdmQABeaker.Items.Add(Beakers[i].Name);
            }
        }

        /**        
         * Funksjon for å fylle inn feltene under prøveinfo
         * 
         * @param   si Data-struktur med parametere som skal fylles inn i feltene
         */
        void populateSampleView(SelectionInfo si)
        {
            bool no_problem = true;
            Detector d = si.SelectedDetector;

            clearSampParams();
            populateSampGeom(d.Name);

            lblToolsDetector.Text = d.Name;
            tbSampCollector.Text = Config.Username;

            tbSampAdvRandErr.Text = d.RandomError.ToString();
            tbSampAdvSystErr.Text = d.SystematicError.ToString();

            tbSampAnalTolerance.Text = d.Tolerance.ToString();
            tbSampAnalSigThresh.Text = d.SignificanceThreshold.ToString();
            tbSampAnalContinuum.Text = d.Continuum.ToString();
            cboxSampAnalContinuumFunc.Text = d.ContinuumFunction;
            cbSampAnalCritLev.Checked = d.CriticalLevel;
            cbSampAnalFitSinglets.Checked = d.FitSinglets;
            cbSampAnalDispRois.Checked = d.DisplayROIs;
            cbSampAnalUseFixed.Checked = d.UseFixedTailParameter;
            cbSampAnalRejectZero.Checked = d.RejectZeroAreaPeaks;
            cbSampAnalFixedFWHM.Checked = d.UseFixedFWHM;
            cboxSampAnalEffCal.Text = d.EfficiencyCalibrationType;
            tbSampAnalMaxFWHMBetween.Text = d.MaxFWHMSBetweenPeaks.ToString();
            tbSampAnalMaxFWHMLeft.Text = d.MaxFWHMSForLeftLimit.ToString();
            tbSampAnalMaxFWHMRight.Text = d.MaxFWHMSForRightLimit.ToString();
            tbSampAnalBkgSub.Text = d.BackgroundSubtract;
            tbSampAnalNIDLib.Text = d.NIDLibrary;
            tbSampAnalNIDConfThresh.Text = d.NIDConfidenceThreshold.ToString();
            tbSampAnalMDAConfFac.Text = d.MDAConfidenceFactor.ToString();
            cbSampAnalInhibitATD.Checked = d.InhibitATDCorrection;
            cbSampAnalUseStoredLib.Checked = d.UseStoredLibrary;
            cbSampAnalPerformMDA.Checked = d.PerformMDATest;

            if (si.AnalType == "Bkg")
            {
                lblSampAnalType.Text = "Bakgrunnsmåling";
                tbSampDesc.Text = "Bakgrunn " + DateTime.Now.ToShortDateString();
                cboxSampGeom.Text = "";
                tbSampQuant.Text = "0";
                cboxSampAdvPreArea.Text = d.QABkgPresetArea;
                tbSampAdvPreAreaValue.Text = d.QABkgPresetAreaValue.ToString();
                tbSampAdvPreAreaChanFrom.Text = d.QABkgPresetAreaChanFrom.ToString();
                tbSampAdvPreAreaChanTo.Text = d.QABkgPresetAreaChanTo.ToString();
                cboxSampAdvPreTime.Text = d.QABkgPresetTime;
                tbSampAdvPreTimeValue.Text = d.QABkgPresetTimeValue.ToString();
                cboxSampAdvPreTimeUnit.Text = d.QABkgPresetTimeUnit;
                lblSampAnalType.Text = "Bakgrunnsmåling";
                SetSampleFieldsStatus(false);
            }
            else if (si.AnalType == "Ref")
            {
                lblSampAnalType.Text = "Referansemåling";
                populateSampGeomWithQA(si.SelectedDetector.Name);

                tbSampDesc.Text = "Referansemåling " + DateTime.Now.ToShortDateString();
                if (si.IsWizard)
                {
                    cboxSampGeom.Text = si.SelectedBeakerInfo.BeakerName;
                    QABeaker qab = getQABeakerByName(si.SelectedBeakerInfo.QAName);
                    tbSampQuant.Text = qab.SampleQuantity.ToString();
                    tbSampID.Text = si.SelectedBeakerInfo.QAName;
                    tbSampType.Text = qab.SampleType;
                    cboxSampQuantUnit.Text = qab.Unit;
                    tbSampQuantUnc.Text = qab.Uncertainty.ToString();
                    addCalFilesToSamp(d, si.SelectedBeakerInfo.BeakerName);
                    dtSampBuildNoneDate.Value = qab.RefDate;
                    dtSampBuildNoneTime.Value = qab.RefDate;
                }
                cboxSampAdvPreArea.Text = d.QARefPresetArea;
                tbSampAdvPreAreaValue.Text = d.QARefPresetAreaValue.ToString();
                tbSampAdvPreAreaChanFrom.Text = d.QARefPresetAreaChanFrom.ToString();
                tbSampAdvPreAreaChanTo.Text = d.QARefPresetAreaChanTo.ToString();
                cboxSampAdvPreTime.Text = d.QARefPresetTime;
                tbSampAdvPreTimeValue.Text = d.QARefPresetTimeValue.ToString();
                cboxSampAdvPreTimeUnit.Text = d.QARefPresetTimeUnit;
                lblSampAnalType.Text = "Referansemåling";
                tabsBuildup.SelectedTab = tabBuildupNone;
                SetSampleFieldsStatus(false);
                if(!si.IsWizard)
                    cboxSampGeom.Enabled = true;
            }
            else
            {
                lblSampAnalType.Text = "Regulær måling";
                if (cboxSampGeom.Items.Count == 1)
                    cboxSampGeom.SelectedIndex = 0;

                if(si.IsWizard)
                    no_problem = populateSampleFromFile(si.SelectedLIMSFile);

                cboxSampAdvPreArea.Text = d.PresetCount;
                tbSampAdvPreAreaValue.Text = d.PresetCountValue.ToString();
                tbSampAdvPreAreaChanFrom.Text = d.PresetCountChanFrom.ToString();
                tbSampAdvPreAreaChanTo.Text = d.PresetCountChanTo.ToString();
                cboxSampAdvPreTime.Text = d.PresetTime;
                tbSampAdvPreTimeValue.Text = d.PresetTimeValue.ToString();
                cboxSampAdvPreTimeUnit.Text = d.PresetTimeUnit;
                tbSampAnalTolerance.Text = d.Tolerance.ToString();
                tbSampAnalSigThresh.Text = d.SignificanceThreshold.ToString();
                tbSampAnalContinuum.Text = d.Continuum.ToString();
                cboxSampAnalContinuumFunc.Text = d.ContinuumFunction;
                cbSampAnalCritLev.Checked = d.CriticalLevel;
                cbSampAnalFitSinglets.Checked = d.FitSinglets;
                cbSampAnalDispRois.Checked = d.DisplayROIs;
                cbSampAnalUseFixed.Checked = d.UseFixedTailParameter;
                cbSampAnalRejectZero.Checked = d.RejectZeroAreaPeaks;
                cbSampAnalFixedFWHM.Checked = d.UseFixedFWHM;
                cboxSampAnalEffCal.Text = d.EfficiencyCalibrationType;
                tbSampAnalMaxFWHMBetween.Text = d.MaxFWHMSBetweenPeaks.ToString();
                tbSampAnalMaxFWHMLeft.Text = d.MaxFWHMSForLeftLimit.ToString();
                tbSampAnalMaxFWHMRight.Text = d.MaxFWHMSForRightLimit.ToString();
                tbSampAnalBkgSub.Text = d.BackgroundSubtract;
                tbSampAnalNIDLib.Text = d.NIDLibrary;
                tbSampAnalNIDConfThresh.Text = d.NIDConfidenceThreshold.ToString();
                tbSampAnalMDAConfFac.Text = d.MDAConfidenceFactor.ToString();
                cbSampAnalInhibitATD.Checked = d.InhibitATDCorrection;
                cbSampAnalUseStoredLib.Checked = d.UseStoredLibrary;
                cbSampAnalPerformMDA.Checked = d.PerformMDATest;
                SetSampleFieldsStatus(true);
            }

            tabs.SelectedTab = pageSample;

            if (si.DoStart && no_problem)
                btnSampStart_Click(null, null);
        }

        /**        
         * Hendelse for valg av "prøve" i hovedmenyen         
         */
        private void btnMenuSample_Click(object sender, EventArgs e)
        {
            SelInfo.Init();
            SelInfo.AllDetectors = Detectors;
            SelInfo.AllBeakers = Beakers;
            SelInfo.AllQABeakers = QABeakers;
            SelInfo.SelectedLIMSFile = SysPar.LimsExport;
            SelInfo.SysPar = SysPar;

            Button b = sender as Button;
            switch (b.Name)
            {
                case "btnMenuRegSample":
                    SelInfo.AnalType = "Sample";
                    break;

                case "btnMenuBkgSample":
                    SelInfo.AnalType = "Bkg";
                    break;

                case "btnMenuRefSample":
                    SelInfo.AnalType = "Ref";
                    break;

                case "btnMenuBarcodeWizard":
                    SelInfo.IsWizard = true;
                    SelInfo.AnalType = "Sample";
                    break;

                case "btnMenuBarcodeWizardBkg":
                    SelInfo.IsWizard = true;
                    SelInfo.AnalType = "Bkg";
                    break;

                case "btnMenuBarcodeWizardRef":
                    SelInfo.IsWizard = true;
                    SelInfo.AnalType = "Ref";
                    break;
            }

            if (SelInfo.IsWizard)
            {
                FormBarcodeSampleWizard form = new FormBarcodeSampleWizard(ref SelInfo);
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;

                populateSampleView(SelInfo);
            }
            else
            {
                UpdateDetectorLists();
                tabs.SelectedTab = pageDetectors;
            }
        }

        /**        
         * Hendelse for å generere bakgrunnsfil basert på resultat i arkivet
         */
        private void btnArchiveCreateBkg_Click(object sender, EventArgs e)
        {
            if (gridArchive.SelectedCells.Count == 0)
                return;
            
            string operation = gridArchive.SelectedRows[0].Cells["Operation"].Value as String;
            if (operation != "Bkg")
            {
                MessageBox.Show("Du må velge en bakgrunnsfil!!");
                return;
            }
            
            string baseName = gridArchive.SelectedRows[0].Cells["Base"].Value.ToString();
            string parFile = baseName + ".PAR";
            JobParams jp = Utils.DeserializeJobParams(parFile);

            string bkgFile = baseName + ".CNF";
            string newBkgFile = Config.BkgDir + jp.DetectorName + "-" + String.Format("{0:00}", jp.SpectrumDate.Day) + String.Format("{0:00}", jp.SpectrumDate.Month) + jp.SpectrumDate.Year.ToString() + ".CNF";

            if(File.Exists(newBkgFile))
                if (MessageBox.Show("Filen finnes fra før, vil du overskrive?", "Spørsmål", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;

            File.Copy(bkgFile, newBkgFile, true);
            lblStatus.Text = "Ny bakgrunnsfil opprettet som " + newBkgFile;

            DialogResult dialogResult = MessageBox.Show("Skal den valgte filen settes som standard Bkg-fil for " + jp.DetectorName, "Sett som standard Bkg-fil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {   
                Detector d = getDetectorByName(jp.DetectorName);
                d.BackgroundSubtract = newBkgFile;
                Utils.SerializeDetectors(Detectors);
            }  
        }

        /**        
         * Hendelse for å opprette nytt beger under administrasjonssidene
         */
        private void btnAdmGeoNew_Click(object sender, EventArgs e)
        {
            FormInputName form = new FormInputName("Velg et navn for geometri");
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!Utils.ValidName(form.SelectedName))
                {
                    MessageBox.Show("Uglyldig tegn i navnet. Bruk kun tall, bokstaver og bindestrek");
                    return;
                }
                Beaker newBeaker = new Beaker();
                newBeaker.Name = form.SelectedName;
                newBeaker.InUse = false;
                Beakers.Add(newBeaker);

                lbAdmGeomList.Items.Clear();
                for (int i = 0; i < Beakers.Count(); i++)
                    lbAdmGeomList.Items.Add(Beakers[i].Name);

                MessageBox.Show("Husk å konfigurere geometri " + newBeaker.Name);
            }
        }

        /**        
         * Hendelse for å vise et spekter fra arkivet
         */
        private void btnArchiveShowSpectrum_Click(object sender, EventArgs e)
        {
            if (gridArchive.SelectedCells.Count == 0)
                return;

            string baseName = gridArchive.SelectedRows[0].Cells["Base"].Value as String;
            string cnfFile = baseName + ".CNF";
            if (!File.Exists(cnfFile))
            {
                MessageBox.Show("Filen " + cnfFile + " ble ikke funnet");
                return;
            }

            lblStatus.Text = "Laster nytt spekter, vent litt...";
            Application.DoEvents();
            string cout;
            Utils.RunCommand("endview.exe", "", out cout, true);
            Process.Start("putview.exe", cnfFile);
            lblStatus.Text = "";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lagre syspar datastrukturen tilbake til fil
            Utils.SerializeSysPar(SysPar);
        }
    }
}