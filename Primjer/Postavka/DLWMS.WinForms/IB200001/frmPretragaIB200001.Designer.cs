namespace DLWMS.WinForms.IB200001
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
            this.dgvStudentiIspit = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOcjene = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.suglasnik = new System.Windows.Forms.Label();
            this.ostalo = new System.Windows.Forms.Label();
            this.samoglasnik = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiIspit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentiIspit
            // 
            this.dgvStudentiIspit.AllowUserToAddRows = false;
            this.dgvStudentiIspit.AllowUserToDeleteRows = false;
            this.dgvStudentiIspit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiIspit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmeti,
            this.BrojPredmeta,
            this.Prosjek,
            this.Ispit});
            this.dgvStudentiIspit.Location = new System.Drawing.Point(12, 57);
            this.dgvStudentiIspit.Name = "dgvStudentiIspit";
            this.dgvStudentiIspit.ReadOnly = true;
            this.dgvStudentiIspit.RowHeadersWidth = 51;
            this.dgvStudentiIspit.RowTemplate.Height = 24;
            this.dgvStudentiIspit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentiIspit.Size = new System.Drawing.Size(1036, 259);
            this.dgvStudentiIspit.TabIndex = 0;
            this.dgvStudentiIspit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentiIspit_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 125;
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            this.PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            this.PolozeniPredmeti.MinimumWidth = 6;
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            this.PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPredmeta
            // 
            this.BrojPredmeta.DataPropertyName = "BrojPredmeta";
            this.BrojPredmeta.HeaderText = "Broj polozenih predmeta";
            this.BrojPredmeta.MinimumWidth = 6;
            this.BrojPredmeta.Name = "BrojPredmeta";
            this.BrojPredmeta.ReadOnly = true;
            this.BrojPredmeta.Width = 125;
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
            // Ispit
            // 
            this.Ispit.HeaderText = "";
            this.Ispit.MinimumWidth = 6;
            this.Ispit.Name = "Ispit";
            this.Ispit.ReadOnly = true;
            this.Ispit.Text = "Ispiti";
            this.Ispit.UseColumnTextForButtonValue = true;
            this.Ispit.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime ili prezime: ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(125, 29);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(923, 22);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.TxtPretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena: ";
            // 
            // lblOcjene
            // 
            this.lblOcjene.AutoSize = true;
            this.lblOcjene.Location = new System.Drawing.Point(197, 322);
            this.lblOcjene.Name = "lblOcjene";
            this.lblOcjene.Size = new System.Drawing.Size(0, 17);
            this.lblOcjene.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Najveći prosjek ostvario: ";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(848, 321);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 17);
            this.lblStudent.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.suglasnik);
            this.groupBox1.Controls.Add(this.ostalo);
            this.groupBox1.Controls.Add(this.samoglasnik);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 255);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generiši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // suglasnik
            // 
            this.suglasnik.AutoSize = true;
            this.suglasnik.Location = new System.Drawing.Point(201, 204);
            this.suglasnik.Name = "suglasnik";
            this.suglasnik.Size = new System.Drawing.Size(0, 17);
            this.suglasnik.TabIndex = 8;
            // 
            // ostalo
            // 
            this.ostalo.AutoSize = true;
            this.ostalo.Location = new System.Drawing.Point(201, 238);
            this.ostalo.Name = "ostalo";
            this.ostalo.Size = new System.Drawing.Size(0, 17);
            this.ostalo.TabIndex = 7;
            // 
            // samoglasnik
            // 
            this.samoglasnik.AutoSize = true;
            this.samoglasnik.Location = new System.Drawing.Point(201, 170);
            this.samoglasnik.Name = "samoglasnik";
            this.samoglasnik.Size = new System.Drawing.Size(0, 17);
            this.samoglasnik.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Suglasnika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ostalo";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Samoglasnika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sadržaj info";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 43);
            this.textBox1.MaxLength = 63000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1016, 120);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unesi sadržaj:";
            // 
            // frmPretragaIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOcjene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentiIspit);
            this.Name = "frmPretragaIB200001";
            this.Text = "frmPretragaIB200001";
            this.Load += new System.EventHandler(this.FrmPretragaIB200001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiIspit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentiIspit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOcjene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label suglasnik;
        private System.Windows.Forms.Label ostalo;
        private System.Windows.Forms.Label samoglasnik;
    }
}