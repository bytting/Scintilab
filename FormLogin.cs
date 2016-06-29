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
using System.DirectoryServices.AccountManagement;

namespace Scintilab
{
    /** @brief Klasse for innlogging */

    public partial class FormLogin : Form
    {
        /** Lagring av innskrevet brukernavn */
        public string Username;
        public bool UseActiveDirectory;

        /** 
         * Konstruktør         
         */
        public FormLogin(bool useAD)
        {
            InitializeComponent();
            UseActiveDirectory = useAD;
        }

        /** 
         * Hendelse for å avbryte login         
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Sett dialogens resultat til "Cancel"
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // Avslutt Scintilab
            Close();
        }

        private void GetUserAndDomain(string username, out string user, out string domain)
        {
            domain = String.Empty;         
            user = username.Trim();
            char[] sep = { '\\' };
            string[] items = user.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length > 1)
            {
                domain = items[0];
                user = items[1];
            }            
        }

        /** 
         * Hendelse for å logge inn
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PrincipalContext pc = null;
            bool isValid = false;
            try
            {
                string user, domain;
                GetUserAndDomain(tbUsername.Text, out user, out domain);
                if (cbUseAD.Checked)
                {
                    if (String.IsNullOrEmpty(domain))                    
                        pc = new PrincipalContext(ContextType.Domain);                    
                    else pc = new PrincipalContext(ContextType.Domain, domain);
                    // Valider brukernavn/passord mot AD
                    isValid = pc.ValidateCredentials(user, tbPassword.Text);
                }
                else
                {
                    // Opprett kontekst
                    if(String.IsNullOrEmpty(domain))
                        pc = new PrincipalContext(ContextType.Machine);
                    else pc = new PrincipalContext(ContextType.Machine, domain);
                    // Valider brukernavn/passord mot system
                    isValid = pc.ValidateCredentials(user, tbPassword.Text);
                }                
            }
            catch (Exception ex)
            {
                // Noe gikk galt, rapporter til bruker
                MessageBox.Show(ex.Message);
                Close(); // Avslutt Scintilab
            }

            if(!isValid)
            {
                // Brukernavn/Passord var ugyldige
                tbUsername.Text = "";
                tbPassword.Text = "";
                lblInfo.Text = "Ugyldig innlogging";
                tbUsername.Focus();
            }
            else
            {
                // Brukernavn/Passord var gyldige
                Username = tbUsername.Text;
                DialogResult = DialogResult.OK; // Sett dialogens resultat
                Close(); // Lukk vindu
            }
        }

        /** 
         * Hendelse for lasting av dialog
         */
        private void FormLogin_Load(object sender, EventArgs e)
        {
            cbUseAD.Checked = UseActiveDirectory;
            lblInfo.Text = "";
            tbUsername.Select();
        }

        /** 
         * Hendelse for inntasting av tegn i felt for brukernavn
         */
        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Hvis tast er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen
                tbPassword.Select(); // Sett felt for passord aktivt
            }
        }

        /** 
         * Hendelse for inntasting av tegn i felt for passord
         */
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Hvis tast er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen
                btnLogin_Click(sender, e); // Kjør samme kode som for innlogging
            }
        }

        private void cbUseAD_CheckedChanged(object sender, EventArgs e)
        {
            UseActiveDirectory = cbUseAD.Checked;
        }
    }
}
