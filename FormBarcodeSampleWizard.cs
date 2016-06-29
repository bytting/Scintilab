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
    /** @brief Klasse for innlesing av strekkoder */

    public partial class FormBarcodeSampleWizard : Form
    {
        // Lager for input parametere
        SelectionInfo SelInfo;
        // Hjelpevariabler
        public string det;

        /** 
         * Konstruktør
         */
        public FormBarcodeSampleWizard(ref SelectionInfo selInfo)
        {
            InitializeComponent();
            // Lagre input parametere
            SelInfo = selInfo;
        }

        /** 
         * Finn datastruktir for detektor basert på navn
         * 
         * @param   name Detektor som skal hentes
         * 
         * @return   Datastruktur for funnet detektor, eller NULL hvis ikke funnet
         */
        private Detector getDetectorByName(string name)
        {
            // Finn en detektor datastruktur i lista over detektorer basert på navn

            // Lager for funnet detektor
            Detector d = null;
            for (int i = 0; i < SelInfo.AllDetectors.Count; i++)
            {
                if (SelInfo.AllDetectors[i].Name.ToUpper() == name.ToUpper())
                {
                    // Lagre funnet detektor og avbryt løkke
                    d = SelInfo.AllDetectors[i];
                    break;
                }
            }
            return d;
        }

        /** 
         * Hendelse for lasting av dialog
         */
        private void FormBarcodeSampleWizard_Load(object sender, EventArgs e)
        {
            // Tøm alle felter
            tabs.HideTabs = true;
            lblStatus.Text = "";
            lblSelectedDetector.Text = "";
            lblErrorDet.Text = "";
            lblErrorGeom.Text = "";
            lblErrorSamp.Text = "";
            lblErrorStart.Text = "";
            tabs.SelectedTab = tabDet;
            tbDetector.Select();
        }

        /** 
         * Hendelse for inntasting av tegn i detektor felt
         */
        private void tbDetector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r') // Hvis tegn er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen

                // Finn valgt detektor
                for (int i = 0; i < SelInfo.AllDetectors.Count(); i++)
                {
                    if (!SelInfo.AllDetectors[i].InUse)
                        continue;

                    if (SelInfo.AllDetectors[i].Name == tbDetector.Text)
                    {
                        det = tbDetector.Text.ToUpper().Trim();
                        Detector d = getDetectorByName(det);
                        // Sett valgt detektor i parameterlisten
                        SelInfo.SelectedDetector = d;
                        lblStatus.Text = "Sjekker om detektor " + d.Name + " er klar";
                        Application.DoEvents();

                        // Sjekk om valgt detektor har en aktiv jobb
                        if (Utils.HasJob(d))
                        {
                            // Vis melding og avbryt
                            lblErrorDet.Text = "Detektor " + d.Name + " har allerede en jobb";
                            Media.PlayWav("failure.wav");
                            tbDetector.Text = "";
                            return;
                        }

                        // Sjekk om valgt detektor er klar
                        if (!Utils.IsDetectorReady(d, ref lblStatus))
                        {
                            // Vis melding og avbryt
                            Media.PlayWav("failure.wav");
                            tbDetector.Text = "";
                            return;
                        }

                        // Oppdater grensesnitt
                        lblSelectedDetector.Text = "Valgt detektor: " + det;
                        lblSelectedDetectorGeom.Text = "Valgt detektor: " + det;
                        if (SelInfo.AnalType == "Bkg")
                        {
                            tabs.SelectedTab = tabStart;
                            tbStart.Select();
                        }
                        else if (SelInfo.AnalType == "Ref")
                        {
                            tabs.SelectedTab = tabGeom;
                            tbGeom.Select();
                        }
                        else
                        {
                            tabs.SelectedTab = tabSamp;
                            tbSampID.Select();
                        }
                        Media.PlayWav("success.wav");
                        return;
                    }
                }

                Media.PlayWav("failure.wav");
                lblErrorDet.Text = "Finner ikke detektor " + tbDetector.Text;
                tbDetector.Text = "";
            }
        }

        /** 
         * Hendelse for inntasting av tegn i prøveID felt
         */
        private void tbSampID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                e.Handled = true;
                string code = tbSampID.Text;
                string fname = SelInfo.SysPar.LimsExport + "/" + code + ".NAI";
                if (File.Exists(fname))
                {
                    Media.PlayWav("success.wav");
                    SelInfo.SelectedLIMSFile = fname;
                    tabs.SelectedTab = tabStart;
                }
                else
                {
                    Media.PlayWav("failure.wav");
                    lblErrorSamp.Text = "Finner ikke filen " + Environment.NewLine + fname;
                    tbSampID.Text = "";
                }
            }
        }

        /** 
         * Hendelse for inntasting av tegn START/MANUELL felt
         */
        private void tbStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                if (tbStart.Text == "START")
                {
                    SelInfo.DoStart = true;
                }
                else if (tbStart.Text == "MANUELL")
                {
                    SelInfo.DoStart = false;
                }
                else
                {
                    lblErrorStart.Text = "Ugyldig kommando " + tbStart.Text;
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /** 
         * Hendelse for inntasting av tegn i beger felt
         */
        private void tbGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Hvis tegn er return
            {
                e.Handled = true; // Dropp "default handler" for denne hendelsen
                Detector d = getDetectorByName(det);
                foreach (BeakerInfo bi in d.BeakerInfoList)
                {
                    if (bi.BeakerName.ToUpper() == tbGeom.Text.ToUpper())
                    {
                        if (!String.IsNullOrEmpty(bi.QAName))
                        {
                            SelInfo.SelectedBeakerInfo = bi;
                            //SelectedGeometry = bi.BeakerName;
                            //SelectedQAName = bi.QAName;

                            Media.PlayWav("success.wav");
                            tabs.SelectedTab = tabStart;
                        }
                        else
                        {
                            lblErrorGeom.Text = "Finner ikke QA beger for " + d.Name + " og beger " + tbGeom.Text;
                            tbGeom.Text = "";
                            Media.PlayWav("failure.wav");
                        }
                        return;
                    }
                }
                lblErrorGeom.Text = "Finner ikke geometri " + tbGeom.Text + " for " + d.Name;
                tbGeom.Text = "";
                Media.PlayWav("failure.wav");
            }
        }

        /** 
         * Hendelse for skifte av fane
         */
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }
    }
}
