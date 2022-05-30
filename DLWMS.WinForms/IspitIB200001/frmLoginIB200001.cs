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
    public partial class frmLoginIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;

        public frmLoginIB200001()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLozinka.Text) && !String.IsNullOrEmpty(txtMail.Text))
            {
                var lista = db.Studenti.AsQueryable();
                lista = lista.Where(x => x.Email == txtMail.Text && x.Lozinka == txtLozinka.Text);
                if (lista.Count()!=0)
                {
                    var student = lista.FirstOrDefault();
                    if (student.Aktivan)
                    {
                        MessageBox.Show("Uspješna prijava");
                        var frm = new frmPotvrdeIB200001();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(Poruke.NalogNijeAktivan);
                    }
                }
                else
                {
                    MessageBox.Show(Poruke.KorisnickiNalogNePostoji);
                }

            }
        }
    }
}
