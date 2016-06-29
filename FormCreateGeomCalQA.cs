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
    /** @brief Klasse for oppretting av Beger/Calibrasjon/QA kombinasjon */

    public partial class FormCreateGeomCalQA : Form
    {
        // Diverse lager for input/output parametere
        List<Beaker> mBeakers;
        List<QABeaker> mQABeakers;
        string mCalDir, mDetector;
        List<string> mUsedGeoms;

        // Lager for dialogens valgte verdier
        public string SelectedGeometry = "";
        public string SelectedCalFile = "";
        public string SelectedQABox = "";

        /** 
         * Konstruktør
         */
        public FormCreateGeomCalQA(string detector, ref List<string> usedGeoms, ref List<Beaker> beakers, ref List<QABeaker> qabeakers, string caldir)
        {
            InitializeComponent();
            // Lagre dialogens inputparametere
            mBeakers = beakers;
            mQABeakers = qabeakers;
            mCalDir = caldir;
            mDetector = detector;
            mUsedGeoms = usedGeoms;
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
            // Lagre valgte verdier, sett dialogens status og lukk dialogen
            SelectedGeometry = cboxGeom.Text;
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
            // Fyll inn dropdown med begere som ikke er i bruk fra før
            bool found;
            foreach (Beaker b in mBeakers)
            {             
                found = false;
                foreach (string usedGeom in mUsedGeoms)
                    if (b.Name.ToUpper() == usedGeom.ToUpper())
                        found = true;

                if (!found)
                {
                    //if(b.InUse)
                        cboxGeom.Items.Add(b.Name);
                }
            }
        }

        /** 
         * Hendelse for valg av beger i dropdown
         */
        private void cboxGeom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string geom = cboxGeom.Text;
            // Avbryt hvis ingen beger er valgt
            if (String.IsNullOrEmpty(geom))
                return;

            // Legg til alle QA-beger som har riktig begertype i dropdown
            cboxQABox.Items.Clear();
            cboxQABox.Items.Add("");
            foreach (QABeaker b in mQABeakers)
                if (b.BeakerName.ToUpper() == geom.ToUpper())
                    cboxQABox.Items.Add(b.Name);

            // Fyll inn alle gyldige .CAL filer for valgt detektor/beger
            cboxCalFiles.Items.Clear();
            string[] files = Directory.GetFiles(mCalDir, mDetector + geom + "*.CAL");
            foreach (string fn in files)
                cboxCalFiles.Items.Add(Path.GetFileName(fn));
        }
    }
}
