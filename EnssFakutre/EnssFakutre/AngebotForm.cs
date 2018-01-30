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
    public partial class AngebotForm : Form
    {
        private dataEns.data.Angebot angebot;
        private Allgemein allgemein;

        public AngebotForm()
        {
            InitializeComponent();
            BindGrid();
            errorProvider1.SetError(btnAngebotReport, "Wenn Sie ein Angebot erstellen möchten, klicken Sie bitte auf die Zeile in der Tabelle");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            dataEns.data.Angebot a = new dataEns.data.Angebot();

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
                a.AngebotNr = txtracun.Text;
            }

            if (!String.IsNullOrEmpty(txtukupno.Text))
            {
                a.Insgessamt = txtukupno.Text;
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
                a.FirmenNameEnssol = txtImeFirmeNase.Text;
            }

            if (!String.IsNullOrEmpty(rtbOpis.Text))
            {
                a.Beschreibung = rtbOpis.Text;
            }

            if (!String.IsNullOrEmpty(Convert.ToString(dtpDatum.Text)))
            {
                a.Datum = dtpDatum.Value;
            }

            DAAngebot.InsertAngebotPodatke(a);
            BindGrid();
            ResetFields();
        }

        private void BindGrid()
        {
            dgvAngebot.DataSource = DAAngebot.AngebotSelectAll();
            dgvAngebot.Columns[0].Visible = false;
            dgvAngebot.ClearSelection();
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

        private void dgvAngebot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int angebotID = Convert.ToInt32(dgvAngebot.SelectedRows[0].Cells[0].Value);
            angebot = DAAngebot.SelectAngebotByID(angebotID);
        }

        private EnssFakutre.Izvjestaji.Angebot _dokument;
        private void btnAngebotReport_Click(object sender, EventArgs e)
        {
            if (dgvAngebot.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAngebot.SelectedRows)
                {
                    int angebotID = Convert.ToInt32(row.Cells[0].Value);
                    if (_dokument == null)
                    {
                        _dokument = new Izvjestaji.Angebot(angebot);
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

        private void AngebotForm_Load(object sender, EventArgs e)
        {

        }

        private void rtbOpis_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

