using DLWMS.WinForms.Helpers;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB200001 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        StudentPredmetStatistika st;
        public frmIzvjestajIB200001(StudentPredmetStatistika s)
        {
            InitializeComponent();
            st = s;
        }

        private void FrmIzvjestajIB200001_Load(object sender, EventArgs e)
        {
            var dt = new DataSetIB200001xsd.SkeniraniIspitiDataTable();
            var broj = db.KorisniciIspitiScan.Where(x => x.Student.Id == st.ID).ToList();
            for(int i = 0; i < broj.Count(); i++)
            {
                var red = dt.NewSkeniraniIspitiRow();
                red.RB = (i + 1).ToString();
                red.Predmet = broj[i].Predmet.Naziv;
                red.Varanje = broj[i].Varanje==true?"Da":"Ne";
                red.Napomena = broj[i].Napomena;
                dt.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
