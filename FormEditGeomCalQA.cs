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
    /** @brief Klasse for editering av Beger/Calibrasjon/QA kombinasjon */

    public partial class FormEditGeomCalQA : Form
    {
        // Diverse lager for input/output parametere
        List<QABeaker> mQABeakers;
        string mCalDir, mDetector;

        public string CurrentCalFile = "";
        public string CurrentQABox = "";
        public string SelectedCalFile = "";
        public string SelectedQABox = "";

        /** 
         * Konstruktør
         */
        public FormEditGeomCalQA(string detector, string beaker, ref List<QABeaker> qabeakers, string caldir)
        {
            InitializeComponent();
            // Lagre dialogens inputparametere
            mQABeakers = qabeakers;
            mCalDir = caldir;
            mDetector = detector;
            tbGeom.Text = beaker;
        }

        /** 
         * Hendelse for å avbryte dialog
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Sett dialogens status og lukk dialogen
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        /** 
         * Hendelse for OK knappen
         */
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Lagre inntastede verdier, sett dialogens status og lukk dialogen
            SelectedCalFile = cboxCalFiles.Text;
            SelectedQABox = cboxQABox.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        /** 
         * Hendelse for lasting av dialogen
         */
        private void FormCreateGeomCalQA_Load(object sender, EventArgs e)
        {
            cboxQABox.Items.Add(""); // Sett inn tomt element
            
            foreach (QABeaker b in mQABeakers)
                if (b.BeakerName.ToUpper() == tbGeom.Text.ToUpper())
                    cboxQABox.Items.Add(b.Name);

            // Legg til alle gyldige .CAL filer i dropdown
            string[] files = Directory.GetFiles(mCalDir, mDetector + tbGeom.Text + "*.CAL");
            foreach (string fn in files)
                cboxCalFiles.Items.Add(fn);

            // Sett defaults for dropdowns
            cboxCalFiles.Text = CurrentCalFile;
            cboxQABox.Text = CurrentQABox;
        }
    }
}
