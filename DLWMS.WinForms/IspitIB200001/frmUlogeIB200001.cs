using DLWMS.WinForms.DB;
using DLWMS.WinForms.IspitIB200001.EntitetiIB200001;
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
    public partial class frmUlogeIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        PomocnaKlasaZaFormuIB200001 d_b;

        public object UlogaIB200001 { get; private set; }

        public frmUlogeIB200001(PomocnaKlasaZaFormuIB200001 red)
        {
            InitializeComponent();
            d_b = red;
        }

        private void DodajUlogu_Click(object sender, EventArgs e)
        {

        }

        private void FrmUlogeIB200001_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Uloge.ToList();
            label1.Text = d_b.ImePrezime;
        }

        private void BtnSpasi_Click(object sender, EventArgs e)
        {
            UlogeIB200001 uloga = comboBox1.SelectedItem as UlogeIB200001;
            Student s = new Student();
            s = db.Studenti.Where(x => x.Id == d_b.Id).FirstOrDefault();
            StudentiUloge studentiUloge = new StudentiUloge();
            studentiUloge.Student = s;
            studentiUloge.Uloge = uloga;
            db.StudentiUloge.Add(studentiUloge);
            db.SaveChanges();
            MessageBox.Show("Usješno spašeno", MessageBoxButtons.OK.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
