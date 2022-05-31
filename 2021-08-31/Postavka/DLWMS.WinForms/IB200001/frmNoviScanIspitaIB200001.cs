using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
    

    public partial class frmNoviScanIspitaIB200001 : Form
    {
        StudentPredmetStatistika st;
        KonekcijaNaBazu db = DLWMSdb.Baza;
        KorisniciIspitiScan sken;
        bool edit = false;
        public frmNoviScanIspitaIB200001(StudentPredmetStatistika s)
        {
            InitializeComponent();
            st = s;
        }

        public frmNoviScanIspitaIB200001(KorisniciIspitiScan sken)
        {
            InitializeComponent();
            this.sken = sken;
        }

        private void FrmNoviScanIspitaIB200001_Load(object sender, EventArgs e)
        {
            if (sken == null)
            {
                UcitajPredmete();
            }
            else
            {
                edit = true;
                Prikazi();
            }
        }

        private void Prikazi()
        {
            if (sken.Predmet != null)
            {
                cmbPredmeti.Text = sken.Predmet.Naziv;
            }
            else
            {
                cmbPredmeti.Text = "Nije se uspjelo ucitati iz bate";
            }
            txtNapomena.Text = sken.Napomena;
            if (sken.SlikaSkenirangoIspita != null)
            {
                pbSlika.Image = Helpers.ImageHelper.FromByteToImage(sken.SlikaSkenirangoIspita);
            }
            cbVaranje.Checked = sken.Varanje;
            
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = db.Predmet.ToList();
            cmbPredmeti.SelectedItem = db.Predmet.ToList().FirstOrDefault();
        }

        private void PbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string putanja = openFileDialog1.FileName;
                pbSlika.Image = Image.FromFile(putanja);

            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                if (Provjer())
                {
                    var novi = new IB200001.KorisniciIspitiScan()
                    {

                        Napomena = txtNapomena.Text,
                        SlikaSkenirangoIspita = DLWMS.WinForms.Helpers.ImageHelper.FromImageToByte(pbSlika.Image),
                        Predmet = cmbPredmeti.SelectedItem as Predmet,
                        Student = db.Studenti.Where(x => x.Id == st.ID).ToList()[0],
                        Varanje = cbVaranje.Checked
                    };
                    db.KorisniciIspitiScan.Add(novi);
                    db.SaveChanges();
                    MessageBox.Show("ČESTITAMO. USPEJŠNO DODANO U BAZU :)");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            { 
                sken.Napomena = txtNapomena.Text;
                sken.SlikaSkenirangoIspita = DLWMS.WinForms.Helpers.ImageHelper.FromImageToByte(pbSlika.Image);
                sken.Predmet = cmbPredmeti.SelectedItem as Predmet;
                sken.Student = db.Studenti.Where(x => x.Id == sken.Student.Id).ToList().FirstOrDefault();
                sken.Varanje = cbVaranje.Checked;
  
                db.Entry(sken).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private bool Provjer()
        {
            if (String.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                errorProvider1.SetError(txtNapomena, Poruke.ObaveznaVrijednost);
                return false;
            }
            if (pbSlika.Image == null)
            {
                errorProvider1.SetError(pbSlika, Poruke.ObaveznaVrijednost);
                return false;
            }
            return true;
                
        }
    }
}
