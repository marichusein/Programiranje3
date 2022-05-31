namespace DLWMS.WinForms.IB200001
{
    partial class frmNoviScanIspitaIB200001
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cbVaranje = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PREDMETI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SLIKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAPOMENA";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(13, 50);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(299, 24);
            this.cmbPredmeti.TabIndex = 3;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(318, 49);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(217, 286);
            this.pbSlika.TabIndex = 4;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.PbSlika_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(13, 98);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(299, 237);
            this.txtNapomena.TabIndex = 5;
            // 
            // cbVaranje
            // 
            this.cbVaranje.AutoSize = true;
            this.cbVaranje.Location = new System.Drawing.Point(12, 349);
            this.cbVaranje.Name = "cbVaranje";
            this.cbVaranje.Size = new System.Drawing.Size(89, 21);
            this.cbVaranje.TabIndex = 6;
            this.cbVaranje.Text = "VARANjE";
            this.cbVaranje.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(457, 342);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 32);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "SPASI";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNoviScanIspitaIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 378);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaIB200001";
            this.Text = "frmNoviScanIspitaIB200001";
            this.Load += new System.EventHandler(this.FrmNoviScanIspitaIB200001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.CheckBox cbVaranje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}