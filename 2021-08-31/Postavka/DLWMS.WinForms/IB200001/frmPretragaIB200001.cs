using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200001
{
    public partial class frmPretragaIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        public frmPretragaIB200001()
        {
     
            InitializeComponent();
            dgvStudentiIspit.AutoGenerateColumns = false;
        }

        private void FrmPretragaIB200001_Load(object sender, EventArgs e)
        {
           
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Student> students=null)
        {
            dgvStudentiIspit.DataSource = null;
            var studenti = students ?? db.Studenti.ToList();
            List<StudentPredmetStatistika> studentPredmetStatistikas = new List<StudentPredmetStatistika>();
            foreach (var student in studenti)
            {
                studentPredmetStatistikas.Add(new StudentPredmetStatistika(student));
            }
            dgvStudentiIspit.DataSource = studentPredmetStatistikas.ToList();
            lblStudent.Text = NajboljiStudent(studentPredmetStatistikas);
            lblOcjene.Text = ProsejkOcjena(studentPredmetStatistikas);
        }

        private string ProsejkOcjena(List<StudentPredmetStatistika> studentPredmetStatistikas)
        {
            string prosejk="0";
            double suma = 0.0;
            int brojac = 0;
            foreach (var student in studentPredmetStatistikas)
            {
                if (student.Prosjek > 0)
                {
                    suma += student.Prosjek;
                    brojac++;
                }
            }
            if (suma != 0)
            {
                return prosejk = (suma/brojac).ToString();
            }
            else
            {
                return prosejk;
            }
        }

        private string NajboljiStudent(List<StudentPredmetStatistika> studentPredmetStatistikas)
        {
            double prosjek=0;
            string ime="NOT_SET";
            foreach  (var student in studentPredmetStatistikas)
            {
                if (prosjek < student.Prosjek)
                {
                    prosjek = student.Prosjek;
                    ime = student.ImePrezime;
                }
            }
            return ime;
        }

        private void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPretraga.Text))
            {
                var filter = txtPretraga.Text.ToLower();
                var lista = db.Studenti.Where(x => x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter));
                if (lista != null)
                {
                    UcitajPodatke(lista.ToList());
                }
               
            }
            else
            {
                UcitajPodatke();
            }
        }

        private void DgvStudentiIspit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student = dgvStudentiIspit.SelectedRows[0].DataBoundItem as StudentPredmetStatistika;
                if (student != null)
                {
                    var frm = new frmScanIspitaIB200001(student);
                    frm.ShowDialog();
                }
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(Prikaz);
            thread.Start();
   
            
        }

        private void Prikaz()
        {
            int brojsamoglansika = 0, brojsuglasnika = 0, brojostalih = 0;
            foreach (var slovo in textBox1.Text)
            {
                if (JeLiZnak(slovo))
                {
                    brojostalih++;
                }
                else
                {
                    if (JeLSamoglasik(slovo))
                    {
                        brojsamoglansika++;
                    }
                    if(!JeLSamoglasik(slovo))
                    {
                        brojsuglasnika++;
                    }
                }
            }
            Action acttion =()=> Prikazi(brojsamoglansika, brojsuglasnika, brojostalih);
            BeginInvoke(acttion);

        }

        private bool JeLiZnak(char slovo)
        {
            if (slovo.ToString() == "!" || slovo.ToString() == "." || slovo.ToString() == "<" || slovo.ToString() == ">" || slovo.ToString() == "*")
            {
                return true;
            }
            return false;
        }

        private bool JeLSamoglasik(char slovo)
        {
            if (slovo.ToString() == "A" || slovo.ToString() == "a" || slovo.ToString() == "E" || slovo.ToString() == "I" || slovo.ToString() == "O" || slovo.ToString() == "U" || slovo.ToString() == "e" || slovo.ToString() == "i" || slovo.ToString() == "o" || slovo.ToString() == "u")
            {
                return true;
            }
            return false;
        }

        private void Prikazi(int brojsamoglansika, int brojsuglasnika, int brojostalih)
        {
            samoglasnik.Text = brojsamoglansika.ToString();
            suglasnik.Text = brojsuglasnika.ToString();
            ostalo.Text = brojostalih.ToString();


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
