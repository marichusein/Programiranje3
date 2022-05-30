namespace DLWMS.WinForms.IspitIB200001
{
    partial class frmPretragaIB200001
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaImePrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.cmSpol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblProsjekDemonstrator = new System.Windows.Forms.Label();
            this.lblNajbolji = new System.Windows.Forms.Label();
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime: ";
            // 
            // txtPretragaImePrezime
            // 
            this.txtPretragaImePrezime.Location = new System.Drawing.Point(129, 9);
            this.txtPretragaImePrezime.Name = "txtPretragaImePrezime";
            this.txtPretragaImePrezime.Size = new System.Drawing.Size(567, 22);
            this.txtPretragaImePrezime.TabIndex = 1;
            this.txtPretragaImePrezime.TextChanged += new System.EventHandler(this.TxtPretragaImePrezime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uloga";
            // 
            // cbUloga
            // 
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Items.AddRange(new object[] {
            "    "});
            this.cbUloga.Location = new System.Drawing.Point(758, 9);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(130, 24);
            this.cbUloga.TabIndex = 3;
            this.cbUloga.SelectedIndexChanged += new System.EventHandler(this.CbUloga_SelectedIndexChanged);
            // 
            // cmSpol
            // 
            this.cmSpol.FormattingEnabled = true;
            this.cmSpol.Location = new System.Drawing.Point(946, 9);
            this.cmSpol.Name = "cmSpol";
            this.cmSpol.Size = new System.Drawing.Size(130, 24);
            this.cmSpol.TabIndex = 5;
            this.cmSpol.SelectedIndexChanged += new System.EventHandler(this.CmSpol_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Polozeni,
            this.BrojPolozeni,
            this.Prosjek,
            this.Spol,
            this.Uloga});
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 354);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prosjek studenata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prosjek demonstratora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Najbolji student";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(182, 411);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 17);
            this.lblProsjek.TabIndex = 10;
            // 
            // lblProsjekDemonstrator
            // 
            this.lblProsjekDemonstrator.AutoSize = true;
            this.lblProsjekDemonstrator.Location = new System.Drawing.Point(182, 444);
            this.lblProsjekDemonstrator.Name = "lblProsjekDemonstrator";
            this.lblProsjekDemonstrator.Size = new System.Drawing.Size(0, 17);
            this.lblProsjekDemonstrator.TabIndex = 11;
            // 
            // lblNajbolji
            // 
            this.lblNajbolji.AutoSize = true;
            this.lblNajbolji.Location = new System.Drawing.Point(182, 477);
            this.lblNajbolji.Name = "lblNajbolji";
            this.lblNajbolji.Size = new System.Drawing.Size(0, 17);
            this.lblNajbolji.TabIndex = 12;
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(856, 411);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(230, 71);
            this.btnPotvrde.TabIndex = 13;
            this.btnPotvrde.Text = "POTVRDE";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.BtnPotvrde_Click);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 125;
            // 
            // Polozeni
            // 
            this.Polozeni.DataPropertyName = "Polozeni";
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Width = 125;
            // 
            // BrojPolozeni
            // 
            this.BrojPolozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozeni.DataPropertyName = "BrojPolozenih";
            this.BrojPolozeni.HeaderText = "Broj polozeni";
            this.BrojPolozeni.MinimumWidth = 6;
            this.BrojPolozeni.Name = "BrojPolozeni";
            this.BrojPolozeni.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            this.Prosjek.Width = 125;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 125;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.MinimumWidth = 6;
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            this.Uloga.Width = 125;
            // 
            // frmPretragaIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 489);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(this.lblNajbolji);
            this.Controls.Add(this.lblProsjekDemonstrator);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmSpol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretragaImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB200001";
            this.Text = "frmPretragaIB200001";
            this.Load += new System.EventHandler(this.FrmPretragaIB200001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaImePrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.ComboBox cmSpol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblProsjekDemonstrator;
        private System.Windows.Forms.Label lblNajbolji;
        private System.Windows.Forms.Button btnPotvrde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
    }
}