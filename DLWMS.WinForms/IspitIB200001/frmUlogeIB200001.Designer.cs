namespace DLWMS.WinForms.IspitIB200001
{
    partial class frmUlogeIB200001
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.dodajUlogu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(12, 43);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(253, 23);
            this.btnSpasi.TabIndex = 1;
            this.btnSpasi.Text = "DODAJ ULOGU";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.BtnSpasi_Click);
            // 
            // dodajUlogu
            // 
            this.dodajUlogu.Location = new System.Drawing.Point(12, 72);
            this.dodajUlogu.Name = "dodajUlogu";
            this.dodajUlogu.Size = new System.Drawing.Size(253, 23);
            this.dodajUlogu.TabIndex = 2;
            this.dodajUlogu.Text = "NOVA ULOGA";
            this.dodajUlogu.UseVisualStyleBackColor = true;
            this.dodajUlogu.Click += new System.EventHandler(this.DodajUlogu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // frmUlogeIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajUlogu);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmUlogeIB200001";
            this.Text = "frmUlogeIB200001";
            this.Load += new System.EventHandler(this.FrmUlogeIB200001_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button dodajUlogu;
        private System.Windows.Forms.Label label1;
    }
}