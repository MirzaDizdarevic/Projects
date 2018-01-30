namespace EnssFakutre
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.txtukupno = new System.Windows.Forms.TextBox();
            this.txtracun = new System.Windows.Forms.TextBox();
            this.txtplz = new System.Windows.Forms.TextBox();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.txtfimra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtImeFirmeNase = new System.Windows.Forms.TextBox();
            this.txtadresafirme = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrikazRacuna = new System.Windows.Forms.Button();
            this.dgvAllgemein = new System.Windows.Forms.DataGridView();
            this.AllgemeineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmennameEnssol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonEnssol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseEnssol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firmenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insgesammt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllgemein)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Lime;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(53, 126);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(142, 42);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Daten Speichern";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stadt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insgesammt €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rechnung Nr.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "PLZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firmenname";
            // 
            // txtgrad
            // 
            this.txtgrad.Location = new System.Drawing.Point(126, 45);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(100, 20);
            this.txtgrad.TabIndex = 2;
            // 
            // txtukupno
            // 
            this.txtukupno.Location = new System.Drawing.Point(310, 71);
            this.txtukupno.Name = "txtukupno";
            this.txtukupno.Size = new System.Drawing.Size(100, 20);
            this.txtukupno.TabIndex = 5;
            this.txtukupno.TextChanged += new System.EventHandler(this.txtukupno_TextChanged);
            // 
            // txtracun
            // 
            this.txtracun.Location = new System.Drawing.Point(126, 71);
            this.txtracun.Name = "txtracun";
            this.txtracun.Size = new System.Drawing.Size(100, 20);
            this.txtracun.TabIndex = 4;
            // 
            // txtplz
            // 
            this.txtplz.Location = new System.Drawing.Point(310, 45);
            this.txtplz.Name = "txtplz";
            this.txtplz.Size = new System.Drawing.Size(100, 20);
            this.txtplz.TabIndex = 3;
            // 
            // txtadresa
            // 
            this.txtadresa.Location = new System.Drawing.Point(310, 19);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(100, 20);
            this.txtadresa.TabIndex = 1;
            // 
            // txtfimra
            // 
            this.txtfimra.Location = new System.Drawing.Point(126, 19);
            this.txtfimra.Name = "txtfimra";
            this.txtfimra.Size = new System.Drawing.Size(100, 20);
            this.txtfimra.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfimra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtadresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtukupno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtracun);
            this.groupBox1.Controls.Add(this.txtgrad);
            this.groupBox1.Controls.Add(this.txtplz);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 113);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allgemeine Daten";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDatum);
            this.groupBox2.Controls.Add(this.txtImeFirmeNase);
            this.groupBox2.Controls.Add(this.txtadresafirme);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(849, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 126);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unsere Daten";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(106, 97);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 21;
            // 
            // txtImeFirmeNase
            // 
            this.txtImeFirmeNase.Location = new System.Drawing.Point(106, 71);
            this.txtImeFirmeNase.Name = "txtImeFirmeNase";
            this.txtImeFirmeNase.Size = new System.Drawing.Size(100, 20);
            this.txtImeFirmeNase.TabIndex = 2;
            this.txtImeFirmeNase.Text = "Enssol d.o.o.";
            // 
            // txtadresafirme
            // 
            this.txtadresafirme.Location = new System.Drawing.Point(106, 45);
            this.txtadresafirme.Name = "txtadresafirme";
            this.txtadresafirme.Size = new System.Drawing.Size(100, 20);
            this.txtadresafirme.TabIndex = 2;
            this.txtadresafirme.Text = "Trg Slobode 16";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 19);
            this.maskedTextBox1.Mask = "(999) 000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.Text = "061820130";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Datum";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Firmenname";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon";
            // 
            // btnPrikazRacuna
            // 
            this.btnPrikazRacuna.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrikazRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikazRacuna.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazRacuna.Location = new System.Drawing.Point(11, 174);
            this.btnPrikazRacuna.Name = "btnPrikazRacuna";
            this.btnPrikazRacuna.Size = new System.Drawing.Size(229, 41);
            this.btnPrikazRacuna.TabIndex = 19;
            this.btnPrikazRacuna.Text = "Rechnung ansehen und drucken";
            this.btnPrikazRacuna.UseVisualStyleBackColor = false;
            this.btnPrikazRacuna.Click += new System.EventHandler(this.btnPrikazRacuna_Click);
            this.btnPrikazRacuna.Validating += new System.ComponentModel.CancelEventHandler(this.btnPrikazRacuna_Validating);
            // 
            // dgvAllgemein
            // 
            this.dgvAllgemein.AllowUserToAddRows = false;
            this.dgvAllgemein.AllowUserToDeleteRows = false;
            this.dgvAllgemein.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllgemein.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllgemeineID,
            this.FirmennameEnssol,
            this.TelefonEnssol,
            this.AdresseEnssol,
            this.Datum,
            this.Firmenname,
            this.Adresse,
            this.PLZ,
            this.Stadt,
            this.Beschreibung,
            this.RechnungNr,
            this.Insgesammt});
            this.dgvAllgemein.Location = new System.Drawing.Point(11, 234);
            this.dgvAllgemein.Name = "dgvAllgemein";
            this.dgvAllgemein.ReadOnly = true;
            this.dgvAllgemein.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllgemein.Size = new System.Drawing.Size(1155, 284);
            this.dgvAllgemein.TabIndex = 16;
            this.dgvAllgemein.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllgemein_CellClick);
            // 
            // AllgemeineID
            // 
            this.AllgemeineID.DataPropertyName = "AllgemeineID";
            this.AllgemeineID.HeaderText = "AllgemeineID";
            this.AllgemeineID.Name = "AllgemeineID";
            this.AllgemeineID.ReadOnly = true;
            this.AllgemeineID.Visible = false;
            // 
            // FirmennameEnssol
            // 
            this.FirmennameEnssol.DataPropertyName = "FirmennameEnssol";
            this.FirmennameEnssol.HeaderText = "Unser Name";
            this.FirmennameEnssol.Name = "FirmennameEnssol";
            this.FirmennameEnssol.ReadOnly = true;
            // 
            // TelefonEnssol
            // 
            this.TelefonEnssol.DataPropertyName = "TelefonEnssol";
            this.TelefonEnssol.HeaderText = "Telefon";
            this.TelefonEnssol.Name = "TelefonEnssol";
            this.TelefonEnssol.ReadOnly = true;
            // 
            // AdresseEnssol
            // 
            this.AdresseEnssol.DataPropertyName = "AdresseEnssol";
            this.AdresseEnssol.HeaderText = "Unsere Adresse";
            this.AdresseEnssol.Name = "AdresseEnssol";
            this.AdresseEnssol.ReadOnly = true;
            this.AdresseEnssol.Width = 110;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Firmenname
            // 
            this.Firmenname.DataPropertyName = "Firmenname";
            this.Firmenname.HeaderText = "Firma";
            this.Firmenname.Name = "Firmenname";
            this.Firmenname.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.DataPropertyName = "Adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // PLZ
            // 
            this.PLZ.DataPropertyName = "PLZ";
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.Name = "PLZ";
            this.PLZ.ReadOnly = true;
            // 
            // Stadt
            // 
            this.Stadt.DataPropertyName = "Stadt";
            this.Stadt.HeaderText = "Stadt";
            this.Stadt.Name = "Stadt";
            this.Stadt.ReadOnly = true;
            // 
            // Beschreibung
            // 
            this.Beschreibung.DataPropertyName = "Beschreibung";
            this.Beschreibung.HeaderText = "Beschreibung";
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.ReadOnly = true;
            // 
            // RechnungNr
            // 
            this.RechnungNr.DataPropertyName = "RechnungNr";
            this.RechnungNr.HeaderText = "Rechnung Nr.";
            this.RechnungNr.Name = "RechnungNr";
            this.RechnungNr.ReadOnly = true;
            // 
            // Insgesammt
            // 
            this.Insgesammt.DataPropertyName = "Insgesammt";
            this.Insgesammt.HeaderText = "Insgessamt";
            this.Insgesammt.Name = "Insgesammt";
            this.Insgesammt.ReadOnly = true;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(369, 94);
            this.rtbOpis.TabIndex = 21;
            this.rtbOpis.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbOpis);
            this.groupBox4.Location = new System.Drawing.Point(468, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 113);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Beschreibung";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(966, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Fenster Schließen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnssFakutre.Properties.Resources.imageedit_5_4383488867;
            this.pictureBox1.Location = new System.Drawing.Point(246, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrikazRacuna);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAllgemein);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllgemein)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.TextBox txtukupno;
        private System.Windows.Forms.TextBox txtracun;
        private System.Windows.Forms.TextBox txtplz;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.TextBox txtfimra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtImeFirmeNase;
        private System.Windows.Forms.TextBox txtadresafirme;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrikazRacuna;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dgvAllgemein;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllgemeineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmennameEnssol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonEnssol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseEnssol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firmenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insgesammt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

