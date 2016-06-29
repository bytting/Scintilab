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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scintilab
{
    /** @brief Klasse for innlesing av et generisk navn fra bruker */

    public partial class FormInputName : Form
    {
        /** Lager for valgt navn */
        public string SelectedName;

        /** 
         * Konstruktør         
         */
        public FormInputName(string caption)
        {
            InitializeComponent();
            lblInfo.Text = caption; // Sett dialog tittel
        }

        /** 
         * Hendelse for OK knappen
         */
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Avbryt med feilmelding hvis feltet for navn er tomt
            if (String.IsNullOrEmpty(tbName.Text))
            {                
                MessageBox.Show("Du må velge et gyldig navn");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            // Lagre navnet i dialogen så den kan hentes ut av klienten
            SelectedName = tbName.Text;
            Close(); // Lukk dialogen
        }

        /** 
         * Hendelse for innlesing av tegn
         */
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Hvis tegnet er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen
                btnOk_Click(sender, e); // Kjør kode for OK knappen
            }
        }
    }
}
