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
            this.lblErrorDet = new System.Windows.Forms.Label();
            this.tbDetector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorSamp = new System.Windows.Forms.Label();
            this.lblSelectedDetector = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSampID = new System.Windows.Forms.TextBox();
            this.lblErrorStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.lblErrorGeom = new System.Windows.Forms.Label();
            this.tbGeom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectedDetectorGeom = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.pageDet = new System.Windows.Forms.TabPage();
            this.pageSamp = new System.Windows.Forms.TabPage();
            this.pageStart = new System.Windows.Forms.TabPage();
            this.pageGeom = new System.Windows.Forms.TabPage();
            this.status.SuspendLayout();
            this.tabs.SuspendLayout();
            this.pageDet.SuspendLayout();
            this.pageSamp.SuspendLayout();
            this.pageStart.SuspendLayout();
            this.pageGeom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorDet
            // 
            this.lblErrorDet.AutoSize = true;
            this.lblErrorDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDet.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDet.Location = new System.Drawing.Point(34, 99);
            this.lblErrorDet.Name = "lblErrorDet";
            this.lblErrorDet.Size = new System.Drawing.Size(48, 13);
            this.lblErrorDet.TabIndex = 2;
            this.lblErrorDet.Text = "<Error>";
            // 
            // tbDetector
            // 
            this.tbDetector.Location = new System.Drawing.Point(31, 50);
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
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les strekkode for detektor";
            // 
            // lblErrorSamp
            // 
            this.lblErrorSamp.AutoSize = true;
            this.lblErrorSamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSamp.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSamp.Location = new System.Drawing.Point(32, 111);
            this.lblErrorSamp.Name = "lblErrorSamp";
            this.lblErrorSamp.Size = new System.Drawing.Size(48, 13);
            this.lblErrorSamp.TabIndex = 3;
            this.lblErrorSamp.Text = "<Error>";
            // 
            // lblSelectedDetector
            // 
            this.lblSelectedDetector.AutoSize = true;
            this.lblSelectedDetector.Location = new System.Drawing.Point(32, 18);
            this.lblSelectedDetector.Name = "lblSelectedDetector";
            this.lblSelectedDetector.Size = new System.Drawing.Size(102, 14);
            this.lblSelectedDetector.TabIndex = 2;
            this.lblSelectedDetector.Text = "<SelectedDetector>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Les inn strekkode for prøve ID";
            // 
            // tbSampID
            // 
            this.tbSampID.Location = new System.Drawing.Point(33, 73);
            this.tbSampID.Margin = new System.Windows.Forms.Padding(2);
            this.tbSampID.Name = "tbSampID";
            this.tbSampID.Size = new System.Drawing.Size(177, 20);
            this.tbSampID.TabIndex = 0;
            this.tbSampID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSampID_KeyPress);
            // 
            // lblErrorStart
            // 
            this.lblErrorStart.AutoSize = true;
            this.lblErrorStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStart.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStart.Location = new System.Drawing.Point(33, 92);
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
            this.label3.Location = new System.Drawing.Point(33, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skann START eller MANUELL";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(33, 50);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(175, 20);
            this.tbStart.TabIndex = 0;
            this.tbStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStart_KeyPress);
            // 
            // lblErrorGeom
            // 
            this.lblErrorGeom.AutoSize = true;
            this.lblErrorGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGeom.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGeom.Location = new System.Drawing.Point(25, 112);
            this.lblErrorGeom.Name = "lblErrorGeom";
            this.lblErrorGeom.Size = new System.Drawing.Size(48, 13);
            this.lblErrorGeom.TabIndex = 3;
            this.lblErrorGeom.Text = "<Error>";
            // 
            // tbGeom
            // 
            this.tbGeom.Location = new System.Drawing.Point(28, 75);
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
            this.label5.Location = new System.Drawing.Point(25, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Les inn strekkode for geometri";
            // 
            // lblSelectedDetectorGeom
            // 
            this.lblSelectedDetectorGeom.AutoSize = true;
            this.lblSelectedDetectorGeom.Location = new System.Drawing.Point(25, 21);
            this.lblSelectedDetectorGeom.Name = "lblSelectedDetectorGeom";
            this.lblSelectedDetectorGeom.Size = new System.Drawing.Size(103, 14);
            this.lblSelectedDetectorGeom.TabIndex = 0;
            this.lblSelectedDetectorGeom.Text = "<Selected detektor>";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 187);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(255, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 17);
            this.lblStatus.Text = "<Status>";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.pageDet);
            this.tabs.Controls.Add(this.pageSamp);
            this.tabs.Controls.Add(this.pageStart);
            this.tabs.Controls.Add(this.pageGeom);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(255, 187);
            this.tabs.TabIndex = 2;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // pageDet
            // 
            this.pageDet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageDet.Controls.Add(this.lblErrorDet);
            this.pageDet.Controls.Add(this.label1);
            this.pageDet.Controls.Add(this.tbDetector);
            this.pageDet.Location = new System.Drawing.Point(4, 23);
            this.pageDet.Name = "pageDet";
            this.pageDet.Padding = new System.Windows.Forms.Padding(3);
            this.pageDet.Size = new System.Drawing.Size(247, 160);
            this.pageDet.TabIndex = 0;
            this.pageDet.Text = "LesDetektor";
            // 
            // pageSamp
            // 
            this.pageSamp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageSamp.Controls.Add(this.lblErrorSamp);
            this.pageSamp.Controls.Add(this.lblSelectedDetector);
            this.pageSamp.Controls.Add(this.tbSampID);
            this.pageSamp.Controls.Add(this.label2);
            this.pageSamp.Location = new System.Drawing.Point(4, 23);
            this.pageSamp.Name = "pageSamp";
            this.pageSamp.Padding = new System.Windows.Forms.Padding(3);
            this.pageSamp.Size = new System.Drawing.Size(247, 160);
            this.pageSamp.TabIndex = 1;
            this.pageSamp.Text = "LesPrøve";
            // 
            // pageStart
            // 
            this.pageStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageStart.Controls.Add(this.lblErrorStart);
            this.pageStart.Controls.Add(this.label3);
            this.pageStart.Controls.Add(this.tbStart);
            this.pageStart.Location = new System.Drawing.Point(4, 23);
            this.pageStart.Name = "pageStart";
            this.pageStart.Padding = new System.Windows.Forms.Padding(3);
            this.pageStart.Size = new System.Drawing.Size(247, 160);
            this.pageStart.TabIndex = 2;
            this.pageStart.Text = "Start";
            // 
            // pageGeom
            // 
            this.pageGeom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageGeom.Controls.Add(this.lblErrorGeom);
            this.pageGeom.Controls.Add(this.lblSelectedDetectorGeom);
            this.pageGeom.Controls.Add(this.tbGeom);
            this.pageGeom.Controls.Add(this.label5);
            this.pageGeom.Location = new System.Drawing.Point(4, 23);
            this.pageGeom.Name = "pageGeom";
            this.pageGeom.Padding = new System.Windows.Forms.Padding(3);
            this.pageGeom.Size = new System.Drawing.Size(247, 160);
            this.pageGeom.TabIndex = 3;
            this.pageGeom.Text = "Geom";
            // 
            // FormBarcodeSampleWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 209);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBarcodeSampleWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scintilab - Les strekkode";
            this.Load += new System.EventHandler(this.FormBarcodeSampleWizard_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.pageDet.ResumeLayout(false);
            this.pageDet.PerformLayout();
            this.pageSamp.ResumeLayout(false);
            this.pageSamp.PerformLayout();
            this.pageStart.ResumeLayout(false);
            this.pageStart.PerformLayout();
            this.pageGeom.ResumeLayout(false);
            this.pageGeom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDetector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSampID;
        private System.Windows.Forms.Label lblSelectedDetector;
        private System.Windows.Forms.Label lblErrorDet;
        private System.Windows.Forms.Label lblErrorSamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label lblErrorStart;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblErrorGeom;
        private System.Windows.Forms.TextBox tbGeom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectedDetectorGeom;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage pageDet;
        private System.Windows.Forms.TabPage pageSamp;
        private System.Windows.Forms.TabPage pageStart;
        private System.Windows.Forms.TabPage pageGeom;
    }
}