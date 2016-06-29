namespace Scintilab
{
    partial class FormCreateGeomCalQA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxGeom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCalFiles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxQABox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 28);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(186, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(261, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geometri";
            // 
            // cboxGeom
            // 
            this.cboxGeom.FormattingEnabled = true;
            this.cboxGeom.Location = new System.Drawing.Point(94, 27);
            this.cboxGeom.Name = "cboxGeom";
            this.cboxGeom.Size = new System.Drawing.Size(190, 21);
            this.cboxGeom.TabIndex = 2;
            this.cboxGeom.SelectedIndexChanged += new System.EventHandler(this.cboxGeom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".CAL fil";
            // 
            // cboxCalFiles
            // 
            this.cboxCalFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCalFiles.FormattingEnabled = true;
            this.cboxCalFiles.Location = new System.Drawing.Point(94, 55);
            this.cboxCalFiles.Name = "cboxCalFiles";
            this.cboxCalFiles.Size = new System.Drawing.Size(190, 21);
            this.cboxCalFiles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "QA boks";
            // 
            // cboxQABox
            // 
            this.cboxQABox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQABox.FormattingEnabled = true;
            this.cboxQABox.Location = new System.Drawing.Point(94, 83);
            this.cboxQABox.Name = "cboxQABox";
            this.cboxQABox.Size = new System.Drawing.Size(190, 21);
            this.cboxQABox.TabIndex = 6;
            // 
            // FormCreateGeomCalQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 171);
            this.Controls.Add(this.cboxQABox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxCalFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxGeom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateGeomCalQA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opprett detektor geometri kombo";
            this.Load += new System.EventHandler(this.FormCreateGeomCalQA_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxGeom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCalFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxQABox;
    }
}