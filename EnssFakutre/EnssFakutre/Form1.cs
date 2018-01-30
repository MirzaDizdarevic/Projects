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
using EnssFakutre.Izvjestaji;


namespace EnssFakutre
{
    public partial class Form1 : Form
    {
        private Allgemein allgemein { get; set; }
        
        

        public Form1()
        {
            InitializeComponent();
            BindGrid();
            errorProvider1.SetError(btnPrikazRacuna, "Wenn Sie eine Rechnung erstellen möchten, klicken Sie bitte auf die Zeile in der Tabelle");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           Allgemein a = new Allgemein();

            if (!String.IsNullOrEmpty(txtfimra.Text))
            {
                a.Firmenname = txtfimra.Text;
            }

            if (!String.IsNullOrEmpty(txtadresa.Text))
            {
                a.Adresse = txtadresa.Text;
            }

            if (!String.IsNullOrEmpty(txtplz.Text))
            {
                a.PLZ = txtplz.Text;
            }

            if (!String.IsNullOrEmpty(txtgrad.Text))
            {
                a.Stadt = txtgrad.Text;
            }

            if (!String.IsNullOrEmpty(txtracun.Text))
            {
                a.RechnungNr = txtracun.Text;
            }

            if (!String.IsNullOrEmpty(txtukupno.Text))
            {
                a.Insgesammt = txtukupno.Text;
            }

            if (!String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                a.TelefonEnssol = maskedTextBox1.Text;
            }

            if (!String.IsNullOrEmpty(txtadresafirme.Text))
            {
                a.AdresseEnssol = txtadresafirme.Text;
            }

            if (!String.IsNullOrEmpty(txtImeFirmeNase.Text))
            {
                a.FirmennameEnssol = txtImeFirmeNase.Text;
            }

            if (!String.IsNullOrEmpty(rtbOpis.Text))
            {
                a.Beschreibung = rtbOpis.Text;
            }

            if (!String.IsNullOrEmpty(dtpDatum.Text))
            {
                a.Datum = Convert.ToDateTime(dtpDatum.Text);
            }



            DAAllgemein.InsertPodatke(a);
            BindGrid();
            ResetFields();
        }

        private void ResetFields()
        {
            txtfimra.Text = String.Empty;
            txtadresa.Text = String.Empty;
            txtgrad.Text = String.Empty;
            txtracun.Text = String.Empty;
            txtukupno.Text = String.Empty;
            txtplz.Text = String.Empty;
            rtbOpis.Text = String.Empty;
            dtpDatum.Text = String.Empty;

        }

        private void BindGrid()
        {
            dgvAllgemein.DataSource = DAAllgemein.AllgemeinSelectAll();
            dgvAllgemein.Columns[0].Visible = false;
            dgvAllgemein.ClearSelection();
        }

        private void txtukupno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
       
        private Rechnung _dokument;
        private void btnPrikazRacuna_Click(object sender, EventArgs e)
        {
            //Rechnung r = new Rechnung(allgemein);
            //r.Show();

            if (dgvAllgemein.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAllgemein.SelectedRows)
                {
                    int allgemeinID = Convert.ToInt32(row.Cells[0].Value);
                    if (_dokument == null)
                    {
                        _dokument = new Rechnung(allgemein);
                        _dokument.FormClosed += dokument_FormClosed;
                        _dokument.Show();
                    }
                    else
                        _dokument.Activate();
                }
            }
        }
        void dokument_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dokument = null;
           
        }

        //private void btnAngebot_Click(object sender, EventArgs e)
        //{
        //    Angebot a = new Angebot();
        //    a.Show();
        //}

        private void dgvAllgemein_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int allgemeineID = Convert.ToInt32(dgvAllgemein.SelectedRows[0].Cells[0].Value);
                allgemein = DAAllgemein.SelectAllgemeinByID(allgemeineID);
         
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazRacuna_Validating(object sender, CancelEventArgs e)
        {
            

        }
    }
}
