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

namespace EnssFakutre.Izvjestaji
{
    public partial class Angebot : Form
    {
        private dataEns.data.Angebot a;
        public Angebot(dataEns.data.Angebot aA)
        {
            InitializeComponent();
            if (aA != null)
            {
                a = aA;
            }
        }

        private void Angebot_Load(object sender, EventArgs e)
        {
            this.rptEnssolPredRacunTableAdapter.Fill(this.enssolDataSet.rptEnssolPredRacun, a.AngebotID);
            this.reportViewer1.RefreshReport();
        }
    }
}
