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
