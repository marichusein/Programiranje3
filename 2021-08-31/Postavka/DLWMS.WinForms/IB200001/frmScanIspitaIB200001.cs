using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200001
{
    public partial class frmScanIspitaIB200001 : Form
    {
        StudentPredmetStatistika s;
        KonekcijaNaBazu db = DLWMSdb.Baza;
        public frmScanIspitaIB200001(StudentPredmetStatistika student)
        {
            InitializeComponent();
            s = student;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void FrmScanIspitaIB200001_Load(object sender, EventArgs e)
        {
            lblStudent.Text = s.ImePrezime;
            Ucitaj();
        }

        private void Ucitaj()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.KorisniciIspitiScan.Where(x => x.Student.Id==s.ID).ToList();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
           
            var frm = new frmNoviScanIspitaIB200001(s);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Ucitaj();
            }
        }

        private void BtnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaji(s);
            frm.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var sken = dataGridView1.Rows[0].DataBoundItem as KorisniciIspitiScan;
                if(MessageBox.Show($"Jeste li sigurni da zelite izbrisati sken?", "UPOZORENjE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                db.KorisniciIspitiScan.Remove(sken);
                db.SaveChanges();
                Ucitaj();
                }
                
            }
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
 
                var sken = dataGridView1.SelectedRows[0].DataBoundItem as KorisniciIspitiScan;
                var frm = new frmNoviScanIspitaIB200001(sken);
                frm.ShowDialog();
            
        }
    }
}
