using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnssFakutre
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRechnung_Click(object sender, EventArgs e)
        {
          
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnPrijedlog_Click(object sender, EventArgs e)
        {
            AngebotForm anf = new AngebotForm();
            anf.Show();
        }
    }
}
