using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scintilab
{
    /** @brief Klasse for generisk visning av tekst */

    public partial class FormQuickView : Form
    {
        /** 
         * Konstruktør         
         */
        public FormQuickView(string content)
        {
            InitializeComponent();
            tbContent.Text = content;
        }

        /** 
         * Hendelse for å avbryte dialog
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); // Lukk vindu
        }

        /** 
         * Hendelse for å printe tekst
         */
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            MultipadPrintDocument printDoc = new MultipadPrintDocument();

            printDoc.PrinterSettings = pd.PrinterSettings;
            printDoc.Font = new Font("Courier New", 9, FontStyle.Regular);
            printDoc.Text = tbContent.Text;
            printDoc.Print();

            //string cout;
            //Utils.RunCommand("DATAPLOT", cnfFile + " /SCALE=" + SysPar.ReportScaleY + " /XSCALE=" + SysPar.ReportScaleX + " /ENHPLOT", out cout, false);
        }
    }
}
