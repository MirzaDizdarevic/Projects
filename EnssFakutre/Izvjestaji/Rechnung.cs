using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataEns.data;
using EnssFakutre.EnssolDataSetTableAdapters;
using Microsoft.Reporting.WinForms;

namespace EnssFakutre.Izvjestaji
{
    public partial class Rechnung : Form
    {

        private Allgemein a;
        public Rechnung(Allgemein aA)
        {
            InitializeComponent();
            if (aA != null)
            {
                a = aA;
            }
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enssolDataSet.rptEnssolRacun' table. You can move, or remove it, as needed.
            this.rptEnssolRacunTableAdapter.Fill(this.enssolDataSet.rptEnssolRacun, a.AllgemeineID);

            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "EnssFakture.Izvjestaji.Rechnung1.rdlc";

            //List<rptEnssolRacun_Result2> dsList = DAAllgemein.SelectReport(a.AllgemeineID);
            //ReportDataSource reportDataSource = new ReportDataSource("Enssol", dsList);
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //this.reportViewer1.RefreshReport();

            //ReportDataSource rds = new ReportDataSource("Enssol", rptEnssolRacunBindingSource);
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //EnssolDataSet ds = new EnssolDataSet();
            //rptEnssolRacunTableAdapter adapter = new rptEnssolRacunTableAdapter();

            //int allgemeineID = Convert.ToInt32(a.AllgemeineID);
            //adapter.Fill(ds.rptEnssolRacun, allgemeineID);
            //rptEnssolRacunBindingSource.DataSource = ds.rptEnssolRacun;
            this.reportViewer1.RefreshReport();
        }
    }
}
