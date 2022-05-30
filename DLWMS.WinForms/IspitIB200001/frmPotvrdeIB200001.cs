using DLWMS.WinForms.DB;
using DLWMS.WinForms.IspitIB200001.EntitetiIB200001;
using DLWMS.WinForms.Reports;
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
    public partial class frmPotvrdeIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        List<StudentiPotvrdeIB200001> iB200001s = new List<StudentiPotvrdeIB200001>();
        public frmPotvrdeIB200001()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void FrmPotvrdeIB200001_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }

        private void UcitajPotvrde()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.StudentiPotvrde.ToList();
            iB200001s = db.StudentiPotvrde.ToList();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var Lista = db.Studenti.ToList();
            Action Akcija = () => UcitajPotvrde();
            Random r = new Random();
            await Task.Run(() =>
            {
                for (int i = 0; i < 15; i++)
                {
                    var Potvrda = new StudentiPotvrdeIB200001();
                    Potvrda.Student = Lista[r.Next(0, Lista.Count())];
                    Potvrda.Datum = DateTime.Now;
                    Potvrda.Izdata = (r.Next(0, 2)) == 1;
                    Potvrda.Svrha = $"Svrha Regulisanje_{i} potvrde";
                    db.StudentiPotvrde.Add(Potvrda);
                }
            });
            db.SaveChanges();
            BeginInvoke(Akcija);
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            db.StudentiPotvrde.RemoveRange(db.StudentiPotvrde);
            db.SaveChanges();
            UcitajPotvrde();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaj(iB200001s);
            frm.ShowDialog();
        }
    }
}
