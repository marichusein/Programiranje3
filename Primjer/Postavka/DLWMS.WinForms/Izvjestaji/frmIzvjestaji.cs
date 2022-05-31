using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB200001;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Linq;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        StudentPredmetStatistika st;
        public frmIzvjestaji(StudentPredmetStatistika s=null)
        {
            InitializeComponent();
            st = s;
        }            
     
        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            var dt = new dsDLWMS.PolozeniDataTable();
            var broj = db.KorisniciIspitiScan.Where(x => x.Student.Id == st.ID).ToList();
            for (int i = 0; i < broj.Count(); i++)
            {
                var red = dt.NewPolozeniRow();
                red.RB = (i + 1).ToString();
                if (broj[i].Predmet != null)
                { 
                    red.Predmet = broj[i].Predmet.Naziv;
                }
                else
                {
                    red.Predmet = "####";
                }
                red.Varanje = broj[i].Varanje == true ? "Da" : "Ne";
                red.Napomena = broj[i].Napomena;
                dt.Rows.Add(red);
            }
            

            // var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;


            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
