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

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        List<IspitIB200001.EntitetiIB200001.StudentiPotvrdeIB200001> potvrde;
        public frmIzvjestaj(List<IspitIB200001.EntitetiIB200001.StudentiPotvrdeIB200001> iB200001s =null)
        {
            InitializeComponent();
            potvrde = iB200001s;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var tabela = new DataSet1.DataTable1DataTable();
            for (int i = 0; i < potvrde.Count(); i++)
            {
                var red = tabela.NewDataTable1Row();
                red.Datum = potvrde[i].Datum.ToString();
                red.Student = potvrde[i].Student.ToString();
                red.Izdata = (potvrde[i].Izdata) ? "Da" : "Ne";
                tabela.AddDataTable1Row(red);
            }
            rds.Name = "DataSet1";
            rds.Value = tabela;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
