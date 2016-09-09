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
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Scintilab
{
    /** @brief Klasse for visning av jobb rapport */

    public partial class FormJobReport : Form
    {
        // Diverse lager for input/output verdier
        string BaseName, ArchiveName;
        bool IsReanal, hasError;
        Detector Detector;
        public bool UpdateDetectors;
        SystemParameters SysPar;
        JobParams jp = null;        

        /** 
         * Konstruktør         
         */
        public FormJobReport(string baseName, string archiveName, bool isReanal, ref Detector detector, SystemParameters sysPar)
        {
            InitializeComponent();
            BaseName = baseName;
            ArchiveName = archiveName;
            Detector = detector;
            SysPar = sysPar;
            IsReanal = isReanal;
            UpdateDetectors = false;            
        }

        /** 
         * Hendelse for lasting av dialog
         */
        private void FormJobReport_Load(object sender, EventArgs e)
        {
            // Opprett filbaner
            string parFile = BaseName + ".PAR";
            string rptFile = BaseName + ".RPT";
            string outFile = BaseName + ".OUT";

            // Sjekk at filer finnes
            if (File.Exists(parFile))
                jp = Utils.DeserializeJobParams(parFile);

            if (File.Exists(rptFile))            
                tbReport.Text = File.ReadAllText(rptFile, Encoding.GetEncoding(1252));            

            hasError = false;
            if (File.Exists(outFile))
            {
                // Sjekk om standard output filen inneholder ordet "Error"
                tbLog.Text = File.ReadAllText(outFile, Encoding.GetEncoding(1252));
                hasError = tbLog.Text.Contains("> Error ");
            }

            cbExportLIMS.Checked = false;
            if (hasError)
            {
                tabs.SelectedTab = tabError;
                cbPrint.Checked = false;
            }
            else
            {
                tabs.SelectedTab = tabReport;
                cbPrint.Checked = true;
                if(jp.Operation == "Sample")
                    cbExportLIMS.Checked = true;
            }

            // Fjern selection fra input felter
            tbReport.Select(0, 0);
            tbLog.Select(0, 0);
        }

        /** 
         * Hendelse for sletting av jobb
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vil du slette denne jobben?", "Konfirmasjon") != System.Windows.Forms.DialogResult.OK)
                return;

            if (File.Exists(BaseName + ".BAT"))
                File.Delete(BaseName + ".BAT");
            if (File.Exists(BaseName + ".RPT"))
                File.Delete(BaseName + ".RPT");
            if (File.Exists(BaseName + ".CNF"))
                File.Delete(BaseName + ".CNF");
            if (File.Exists(BaseName + ".PAR"))
                File.Delete(BaseName + ".PAR");
            if (File.Exists(BaseName + ".OUT"))
                File.Delete(BaseName + ".OUT");

            Close();
        }

        /** 
         * Hendelse for arkivering av jobb
         */
        private void btnStore_Click(object sender, EventArgs e)
        {
            if (hasError)
            {
                DialogResult dialogresult = MessageBox.Show("NB! Denne analysen ble fullført med feilmelding fra Genie-2000!" + Environment.NewLine + "Vil du lagre allikevel?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult != DialogResult.Yes)
                    return;
            }

            string rptFile = BaseName + ".RPT";
            string cnfFile = BaseName + ".CNF";
            string parFile = BaseName + ".PAR";
            string outFile = BaseName + ".OUT";
            string batFile = BaseName + ".BAT";

            if (File.Exists(rptFile) && File.Exists(cnfFile) && File.Exists(parFile))
            {
                if (IsReanal)
                {
                    string year = "20" + jp.SpecRef.Substring(2, 2);

                    string newRpt = Config.ArchiveDir + jp.DetectorName + Path.DirectorySeparatorChar + year + Path.DirectorySeparatorChar + jp.SpecRef + "-" + jp.SampleID + "-" + jp.Operation + "-" + jp.CollectorName + ".RPT";
                    string newPar = Config.ArchiveDir + jp.DetectorName + Path.DirectorySeparatorChar + year + Path.DirectorySeparatorChar + jp.SpecRef + "-" + jp.SampleID + "-" + jp.Operation + "-" + jp.CollectorName + ".PAR";
                    string newCnf = Config.ArchiveDir + jp.DetectorName + Path.DirectorySeparatorChar + year + Path.DirectorySeparatorChar + jp.SpecRef + "-" + jp.SampleID + "-" + jp.Operation + "-" + jp.CollectorName + ".CNF";

                    string oldRpt = ArchiveName + ".RPT";
                    string oldPar = ArchiveName + ".PAR";
                    string oldCnf = ArchiveName + ".CNF";

                    File.Copy(rptFile, newRpt, true);
                    File.Copy(cnfFile, newCnf, true);
                    File.Copy(parFile, newPar, true);

                    if (newRpt != oldRpt)
                        File.Delete(oldRpt);
                    if (newPar != oldPar)
                        File.Delete(oldPar);
                    if (newCnf != oldCnf)
                        File.Delete(oldCnf);

                    if (cbExportLIMS.Checked)
                        File.Copy(rptFile, SysPar.LimsImport + jp.SampleID + ".NAI.RES", true);

                    File.Delete(batFile);
                    File.Delete(outFile);
                    lblStatus.Text = "Reanalyse av spekter " + jp.SpecRef + " ble lagret";

                    if (cbPrint.Checked)
                    {
                        PrintDialog pd = new PrintDialog();
                        pd.PrinterSettings = new PrinterSettings();
                        MultipadPrintDocument printDoc = new MultipadPrintDocument();
                        printDoc.PrinterSettings = pd.PrinterSettings;
                        printDoc.Font = new Font("Courier New", 9, FontStyle.Regular);
                        printDoc.Text = File.ReadAllText(rptFile, Encoding.GetEncoding(1252));
                        printDoc.Print();

                        string cout;
                        Utils.RunCommand("DATAPLOT", cnfFile + " /SCALE=" + SysPar.ReportScaleY + " /XSCALE=" + SysPar.ReportScaleX + " /ENHPLOT", out cout, true);
                    }

                    File.Delete(rptFile);
                    File.Delete(cnfFile);
                    File.Delete(parFile);

                    // Logg aktivitet
                    Config.LogMessage("Reanalysering av spekref " + jp.SpecRef);
                }
                else
                {
                    string year = "20" + jp.SpecRef.Substring(2, 2);
                    string archiveDir = Config.ArchiveDir + Detector.Name + Path.DirectorySeparatorChar + year + Path.DirectorySeparatorChar;
                    string baseName = jp.SpecRef + "-" + jp.SampleID + "-" + jp.Operation + "-" + jp.CollectorName;
                    string cnfFileDest = archiveDir + baseName + ".CNF";
                    string rptFileDest = archiveDir + baseName + ".RPT";

                    if (!Directory.Exists(Config.ArchiveDir + Detector.Name))
                        Directory.CreateDirectory(Config.ArchiveDir + Detector.Name);
                    if (!Directory.Exists(Config.ArchiveDir + Detector.Name + Path.DirectorySeparatorChar + year))                    
                        Directory.CreateDirectory(Config.ArchiveDir + Detector.Name + Path.DirectorySeparatorChar + year);

                    Detector.SpectrumCounter++;
                    UpdateDetectors = true;    

                    if (Directory.GetFiles(Config.ArchiveDir + Detector.Name + Path.DirectorySeparatorChar + year, Detector.Name + "*.CNF").Length == 0)
                        Detector.SpectrumCounter = 0;                    

                    if (cbExportLIMS.Checked)    
                        File.Copy(rptFile, SysPar.LimsImport + jp.SampleID + ".NAI.RES", true);

                    File.Move(rptFile, rptFileDest);
                    File.Move(cnfFile, cnfFileDest);
                    File.Move(parFile, archiveDir + baseName + ".PAR");
                    
                    File.Delete(batFile);
                    File.Delete(outFile);                                    

                    lblStatus.Text = "Jobb for detektor " + Detector.Name + " ble arkivert som " + baseName;

                    if (cbPrint.Checked)
                    {
                        PrintDialog pd = new PrintDialog();
                        pd.PrinterSettings = new PrinterSettings();
                        MultipadPrintDocument printDoc = new MultipadPrintDocument();

                        printDoc.PrinterSettings = pd.PrinterSettings;
                        printDoc.Font = new Font("Courier New", 9, FontStyle.Regular);
                        printDoc.Text = File.ReadAllText(rptFileDest, Encoding.GetEncoding(1252));
                        printDoc.Print();

                        string cout;
                        Utils.RunCommand("DATAPLOT", cnfFileDest + " /SCALE=" + SysPar.ReportScaleY + " /XSCALE=" + SysPar.ReportScaleX + " /ENHPLOT", out cout, true);
                    }

                    // Logg aktivitet
                    Config.LogMessage("Analysering av spekref " + jp.SpecRef);
                }
            }
            else
            {
                MessageBox.Show("En eller flere filer ble ikke funnet");
            }

            Close();
        }        
    }
}
