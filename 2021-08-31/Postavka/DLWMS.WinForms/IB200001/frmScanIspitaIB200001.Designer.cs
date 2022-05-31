namespace DLWMS.WinForms.IB200001
{
    partial class frmScanIspitaIB200001
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.BRISI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZA STUDENTA:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(65, 13);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 17);
            this.lblStudent.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.BRISI});
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 351);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Width = 125;
            // 
            // ScanIspita
            // 
            this.ScanIspita.DataPropertyName = "SlikaSkenirangoIspita";
            this.ScanIspita.HeaderText = "Scan ispita";
            this.ScanIspita.MinimumWidth = 6;
            this.ScanIspita.Name = "ScanIspita";
            this.ScanIspita.ReadOnly = true;
            this.ScanIspita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScanIspita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ScanIspita.Width = 125;
            // 
            // BRISI
            // 
            this.BRISI.HeaderText = "";
            this.BRISI.MinimumWidth = 6;
            this.BRISI.Name = "BRISI";
            this.BRISI.ReadOnly = true;
            this.BRISI.Text = "BRISI";
            this.BRISI.UseColumnTextForButtonValue = true;
            this.BRISI.Width = 125;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(606, 5);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(182, 32);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "DODAJ SCAN ISPITA";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(684, 400);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(104, 38);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.BtnPrintaj_Click);
            // 
            // frmScanIspitaIB200001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB200001";
            this.Text = "frmScanIspitaIB200001";
            this.Load += new System.EventHandler(this.FrmScanIspitaIB200001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn BRISI;
    }
}