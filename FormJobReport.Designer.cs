namespace Scintilab
{
    partial class FormJobReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobReport));
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.tabError = new System.Windows.Forms.TabPage();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbExportLIMS = new System.Windows.Forms.CheckBox();
            this.cbPrint = new System.Windows.Forms.CheckBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tabError.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 380);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(735, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabReport);
            this.tabs.Controls.Add(this.tabError);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(735, 354);
            this.tabs.TabIndex = 2;
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabReport.Controls.Add(this.tbReport);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(727, 328);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Rapport";
            // 
            // tbReport
            // 
            this.tbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReport.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReport.Location = new System.Drawing.Point(3, 3);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.ReadOnly = true;
            this.tbReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReport.Size = new System.Drawing.Size(721, 322);
            this.tbReport.TabIndex = 0;
            // 
            // tabError
            // 
            this.tabError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabError.Controls.Add(this.tbLog);
            this.tabError.Location = new System.Drawing.Point(4, 22);
            this.tabError.Name = "tabError";
            this.tabError.Padding = new System.Windows.Forms.Padding(3);
            this.tabError.Size = new System.Drawing.Size(727, 328);
            this.tabError.TabIndex = 1;
            this.tabError.Text = "Logg";
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 3);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(721, 322);
            this.tbLog.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbExportLIMS);
            this.panel1.Controls.Add(this.cbPrint);
            this.panel1.Controls.Add(this.btnStore);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 26);
            this.panel1.TabIndex = 3;
            // 
            // cbExportLIMS
            // 
            this.cbExportLIMS.AutoSize = true;
            this.cbExportLIMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbExportLIMS.Location = new System.Drawing.Point(408, 0);
            this.cbExportLIMS.Name = "cbExportLIMS";
            this.cbExportLIMS.Size = new System.Drawing.Size(85, 26);
            this.cbExportLIMS.TabIndex = 3;
            this.cbExportLIMS.Text = "Skal til LIMS";
            this.cbExportLIMS.UseVisualStyleBackColor = true;
            // 
            // cbPrint
            // 
            this.cbPrint.AutoSize = true;
            this.cbPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbPrint.Location = new System.Drawing.Point(493, 0);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbPrint.Size = new System.Drawing.Size(92, 26);
            this.cbPrint.TabIndex = 2;
            this.cbPrint.Text = "Skriv ut";
            this.cbPrint.UseVisualStyleBackColor = true;
            // 
            // btnStore
            // 
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStore.Location = new System.Drawing.Point(585, 0);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 26);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Arkiver";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(660, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Slett";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormJobReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 402);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJobReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jobb rapport";
            this.Load += new System.EventHandler(this.FormJobReport_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.tabError.ResumeLayout(false);
            this.tabError.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbPrint;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.CheckBox cbExportLIMS;
    }
}