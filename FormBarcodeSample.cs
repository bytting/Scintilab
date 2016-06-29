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

namespace Scintilab
{
    /** @brief Klasse for innlesing av strekkode */

    public partial class FormBarcodeSample : Form
    {
        // Diverse lager for input/output parametere
        public string LimsExpDir, LimsFile;

        /** 
         * Konstruktør
         */
        public FormBarcodeSample()
        {
            InitializeComponent();
        }

        /** 
         * Hendelse for lasting av dialog
         */
        private void FormBarcodeSample_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            tbBarcode.Select();
        }

        /** 
         * Hendelse for inntasting av tegn i strekkode feltet
         */
        private void tbBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Hvis tegn er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen
                string code = tbBarcode.Text;
                string fname = LimsExpDir + "/" + code + ".NAI";
                if(File.Exists(fname))
                {
                    Media.PlayWav("success.wav");
                    LimsFile = fname;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Media.PlayWav("failure.wav");
                    MessageBox.Show("Finner ikke filen " + fname);
                    tbBarcode.Text = "";
                }
            }
        }
    }
}
