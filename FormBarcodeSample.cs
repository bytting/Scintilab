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
