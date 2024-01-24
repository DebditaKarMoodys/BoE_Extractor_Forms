namespace BoE_Extractor_Forms
{
    partial class Form1
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
            this.txtTlPath = new System.Windows.Forms.TextBox();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnTlPath = new System.Windows.Forms.Button();
            this.btnExcelPath = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTlPath
            // 
            this.txtTlPath.Location = new System.Drawing.Point(127, 45);
            this.txtTlPath.Name = "txtTlPath";
            this.txtTlPath.Size = new System.Drawing.Size(416, 20);
            this.txtTlPath.TabIndex = 0;
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(127, 157);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(416, 20);
            this.txtExcelPath.TabIndex = 1;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(127, 271);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(416, 20);
            this.txtOutputFolder.TabIndex = 2;
            // 
            // btnTlPath
            // 
            this.btnTlPath.Location = new System.Drawing.Point(607, 45);
            this.btnTlPath.Name = "btnTlPath";
            this.btnTlPath.Size = new System.Drawing.Size(120, 20);
            this.btnTlPath.TabIndex = 3;
            this.btnTlPath.Text = "tl File Path";
            this.btnTlPath.UseVisualStyleBackColor = true;
            this.btnTlPath.Click += new System.EventHandler(this.btnTlPath_Click);
            // 
            // btnExcelPath
            // 
            this.btnExcelPath.Location = new System.Drawing.Point(607, 157);
            this.btnExcelPath.Name = "btnExcelPath";
            this.btnExcelPath.Size = new System.Drawing.Size(120, 20);
            this.btnExcelPath.TabIndex = 4;
            this.btnExcelPath.Text = "Excel File Path";
            this.btnExcelPath.UseVisualStyleBackColor = true;
            this.btnExcelPath.Click += new System.EventHandler(this.btnExcelPath_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(607, 270);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(120, 20);
            this.btnOutputFolder.TabIndex = 5;
            this.btnOutputFolder.Text = "Output Path";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(345, 334);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(248, 37);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(886, 428);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.btnExcelPath);
            this.Controls.Add(this.btnTlPath);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.txtTlPath);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTlPath;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnTlPath;
        private System.Windows.Forms.Button btnExcelPath;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Button btnGenerate;
    }
}

