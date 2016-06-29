namespace Scintilab
{
    partial class FormBarcodeSampleWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new TabControlWizard.TabControlWizard();
            this.tabDet = new System.Windows.Forms.TabPage();
            this.lblErrorDet = new System.Windows.Forms.Label();
            this.tbDetector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSamp = new System.Windows.Forms.TabPage();
            this.lblErrorSamp = new System.Windows.Forms.Label();
            this.lblSelectedDetector = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSampID = new System.Windows.Forms.TextBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.lblErrorStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tabGeom = new System.Windows.Forms.TabPage();
            this.lblErrorGeom = new System.Windows.Forms.Label();
            this.tbGeom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectedDetectorGeom = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabs.SuspendLayout();
            this.tabDet.SuspendLayout();
            this.tabSamp.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.tabGeom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabDet);
            this.tabs.Controls.Add(this.tabSamp);
            this.tabs.Controls.Add(this.tabStart);
            this.tabs.Controls.Add(this.tabGeom);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(251, 190);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabDet
            // 
            this.tabDet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabDet.Controls.Add(this.lblErrorDet);
            this.tabDet.Controls.Add(this.tbDetector);
            this.tabDet.Controls.Add(this.label1);
            this.tabDet.Location = new System.Drawing.Point(4, 23);
            this.tabDet.Margin = new System.Windows.Forms.Padding(2);
            this.tabDet.Name = "tabDet";
            this.tabDet.Padding = new System.Windows.Forms.Padding(2);
            this.tabDet.Size = new System.Drawing.Size(243, 163);
            this.tabDet.TabIndex = 0;
            this.tabDet.Text = "LesDetektor";
            // 
            // lblErrorDet
            // 
            this.lblErrorDet.AutoSize = true;
            this.lblErrorDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDet.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDet.Location = new System.Drawing.Point(32, 78);
            this.lblErrorDet.Name = "lblErrorDet";
            this.lblErrorDet.Size = new System.Drawing.Size(48, 13);
            this.lblErrorDet.TabIndex = 2;
            this.lblErrorDet.Text = "<Error>";
            // 
            // tbDetector
            // 
            this.tbDetector.Location = new System.Drawing.Point(29, 45);
            this.tbDetector.Margin = new System.Windows.Forms.Padding(2);
            this.tbDetector.Name = "tbDetector";
            this.tbDetector.Size = new System.Drawing.Size(180, 20);
            this.tbDetector.TabIndex = 1;
            this.tbDetector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDetector_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les strekkode for detektor";
            // 
            // tabSamp
            // 
            this.tabSamp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSamp.Controls.Add(this.lblErrorSamp);
            this.tabSamp.Controls.Add(this.lblSelectedDetector);
            this.tabSamp.Controls.Add(this.label2);
            this.tabSamp.Controls.Add(this.tbSampID);
            this.tabSamp.Location = new System.Drawing.Point(4, 23);
            this.tabSamp.Margin = new System.Windows.Forms.Padding(2);
            this.tabSamp.Name = "tabSamp";
            this.tabSamp.Padding = new System.Windows.Forms.Padding(2);
            this.tabSamp.Size = new System.Drawing.Size(243, 163);
            this.tabSamp.TabIndex = 1;
            this.tabSamp.Text = "LesPrøve";
            // 
            // lblErrorSamp
            // 
            this.lblErrorSamp.AutoSize = true;
            this.lblErrorSamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSamp.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSamp.Location = new System.Drawing.Point(31, 105);
            this.lblErrorSamp.Name = "lblErrorSamp";
            this.lblErrorSamp.Size = new System.Drawing.Size(48, 13);
            this.lblErrorSamp.TabIndex = 3;
            this.lblErrorSamp.Text = "<Error>";
            // 
            // lblSelectedDetector
            // 
            this.lblSelectedDetector.AutoSize = true;
            this.lblSelectedDetector.Location = new System.Drawing.Point(28, 16);
            this.lblSelectedDetector.Name = "lblSelectedDetector";
            this.lblSelectedDetector.Size = new System.Drawing.Size(102, 13);
            this.lblSelectedDetector.TabIndex = 2;
            this.lblSelectedDetector.Text = "<SelectedDetector>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Les inn strekkode for prøve ID";
            // 
            // tbSampID
            // 
            this.tbSampID.Location = new System.Drawing.Point(31, 68);
            this.tbSampID.Margin = new System.Windows.Forms.Padding(2);
            this.tbSampID.Name = "tbSampID";
            this.tbSampID.Size = new System.Drawing.Size(177, 20);
            this.tbSampID.TabIndex = 0;
            this.tbSampID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSampID_KeyPress);
            // 
            // tabStart
            // 
            this.tabStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabStart.Controls.Add(this.lblErrorStart);
            this.tabStart.Controls.Add(this.label3);
            this.tabStart.Controls.Add(this.tbStart);
            this.tabStart.Location = new System.Drawing.Point(4, 23);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(243, 163);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "Start";
            // 
            // lblErrorStart
            // 
            this.lblErrorStart.AutoSize = true;
            this.lblErrorStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStart.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStart.Location = new System.Drawing.Point(30, 71);
            this.lblErrorStart.Name = "lblErrorStart";
            this.lblErrorStart.Size = new System.Drawing.Size(48, 13);
            this.lblErrorStart.TabIndex = 2;
            this.lblErrorStart.Text = "<Error>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skann START eller MANUELL";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(33, 36);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(175, 20);
            this.tbStart.TabIndex = 0;
            this.tbStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStart_KeyPress);
            // 
            // tabGeom
            // 
            this.tabGeom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabGeom.Controls.Add(this.lblErrorGeom);
            this.tabGeom.Controls.Add(this.tbGeom);
            this.tabGeom.Controls.Add(this.label5);
            this.tabGeom.Controls.Add(this.lblSelectedDetectorGeom);
            this.tabGeom.Location = new System.Drawing.Point(4, 23);
            this.tabGeom.Name = "tabGeom";
            this.tabGeom.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeom.Size = new System.Drawing.Size(243, 163);
            this.tabGeom.TabIndex = 3;
            this.tabGeom.Text = "Geom";
            // 
            // lblErrorGeom
            // 
            this.lblErrorGeom.AutoSize = true;
            this.lblErrorGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGeom.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGeom.Location = new System.Drawing.Point(33, 92);
            this.lblErrorGeom.Name = "lblErrorGeom";
            this.lblErrorGeom.Size = new System.Drawing.Size(41, 13);
            this.lblErrorGeom.TabIndex = 3;
            this.lblErrorGeom.Text = "label6";
            // 
            // tbGeom
            // 
            this.tbGeom.Location = new System.Drawing.Point(35, 60);
            this.tbGeom.Name = "tbGeom";
            this.tbGeom.Size = new System.Drawing.Size(177, 20);
            this.tbGeom.TabIndex = 2;
            this.tbGeom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGeom_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(33, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Les inn strekkode for geometri";
            // 
            // lblSelectedDetectorGeom
            // 
            this.lblSelectedDetectorGeom.AutoSize = true;
            this.lblSelectedDetectorGeom.Location = new System.Drawing.Point(31, 17);
            this.lblSelectedDetectorGeom.Name = "lblSelectedDetectorGeom";
            this.lblSelectedDetectorGeom.Size = new System.Drawing.Size(103, 13);
            this.lblSelectedDetectorGeom.TabIndex = 0;
            this.lblSelectedDetectorGeom.Text = "<Selected detektor>";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 190);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(251, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 17);
            this.lblStatus.Text = "<Status>";
            // 
            // FormBarcodeSampleWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 212);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBarcodeSampleWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scintilab - Les strekkode";
            this.Load += new System.EventHandler(this.FormBarcodeSampleWizard_Load);
            this.tabs.ResumeLayout(false);
            this.tabDet.ResumeLayout(false);
            this.tabDet.PerformLayout();
            this.tabSamp.ResumeLayout(false);
            this.tabSamp.PerformLayout();
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.tabGeom.ResumeLayout(false);
            this.tabGeom.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControlWizard.TabControlWizard tabs;
        private System.Windows.Forms.TabPage tabDet;
        private System.Windows.Forms.TabPage tabSamp;
        private System.Windows.Forms.TextBox tbDetector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSampID;
        private System.Windows.Forms.Label lblSelectedDetector;
        private System.Windows.Forms.Label lblErrorDet;
        private System.Windows.Forms.Label lblErrorSamp;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label lblErrorStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabPage tabGeom;
        private System.Windows.Forms.Label lblErrorGeom;
        private System.Windows.Forms.TextBox tbGeom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectedDetectorGeom;
    }
}