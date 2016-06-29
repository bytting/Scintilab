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
