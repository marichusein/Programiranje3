using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB200001
{
    public partial class frmPretragaIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        public frmPretragaIB200001()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void FrmPretragaIB200001_Load(object sender, EventArgs e)
        {
            Ucitaj();
            UcitajKombo();
        }

        private void UcitajKombo()
        {
            cbUloga.DataSource = db.Uloge.ToList();
            cbUloga.Text = "_";
            cmSpol.DataSource = db.Spol.ToList();
            cmSpol.Text = "_";
        }

        private void Ucitaj(List<Student> list=null)
        {
            var listica = new List<Student>();
            if (list == null)
            {
                listica = db.Studenti.ToList();
            }
            //else
            //{
            //    listica = list;
            //}
            var filter = listica.AsQueryable();
            if (!String.IsNullOrWhiteSpace(txtPretragaImePrezime.Text))
            {
                filter=filter.Where(x => x.Ime.ToLower().Contains(txtPretragaImePrezime.Text.ToLower()) || x.Prezime.ToLower().Contains(txtPretragaImePrezime.Text.ToLower()));
            }
            if (cbUloga.Text != "_")
            {
                var listaStudentUloge = db.StudentiUloge;
                var lista = listaStudentUloge.Where(x => x.Uloge.Naziv.ToLower() == cbUloga.Text.ToLower());
                var listaIDa = lista.Select(x => x.Student.Id);
                filter = filter.Where(x => listaIDa.Contains(x.Id));
          
            }
            if (cmSpol.Text != "*********")
            {
                filter = filter.Where(x => x.Spol.Naziv == cmSpol.Text);
            }
            listica = filter.ToList();
            var listazaprikaz = new List<PomocnaKlasaZaFormuIB200001>();
            foreach (var item in listica)
            {
                listazaprikaz.Add(new PomocnaKlasaZaFormuIB200001(item));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listazaprikaz.ToList();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPotvrde_Click(object sender, EventArgs e)
        {
            var frm = new frmLoginIB200001();
            frm.ShowDialog();
        }

        private void TxtPretragaImePrezime_TextChanged(object sender, EventArgs e)
        {
                Ucitaj();
        }

        private void CbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
            cbUloga.Enabled = false;
        }

        private void CmSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var red = dataGridView1.Rows[0].DataBoundItem as PomocnaKlasaZaFormuIB200001;
                var frm = new frmUlogeIB200001(red);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Ucitaj();
                }
            }
        }
    }
}
