namespace EnssFakutre
{
    partial class AngebotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngebotForm));
            this.dgvAngebot = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfimra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtukupno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtracun = new System.Windows.Forms.TextBox();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.txtplz = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtadresafirme = new System.Windows.Forms.TextBox();
            this.txtImeFirmeNase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnAngebotReport = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngebot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAngebot
            // 
            this.dgvAngebot.AllowUserToAddRows = false;
            this.dgvAngebot.AllowUserToDeleteRows = false;
            this.dgvAngebot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngebot.Location = new System.Drawing.Point(12, 230);
            this.dgvAngebot.Name = "dgvAngebot";
            this.dgvAngebot.ReadOnly = true;
            this.dgvAngebot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngebot.Size = new System.Drawing.Size(1180, 293);
            this.dgvAngebot.TabIndex = 0;
            this.dgvAngebot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAngebot_CellClick);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtfimra
            // 
            this.txtfimra.Location = new System.Drawing.Point(117, 19);
            this.txtfimra.Name = "txtfimra";
            this.txtfimra.Size = new System.Drawing.Size(195, 20);
            this.txtfimra.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Firmenname";
            // 
            // txtadresa
            // 
            this.txtadresa.Location = new System.Drawing.Point(393, 19);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(195, 20);
            this.txtadresa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Insgesammt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Stadt";
            // 
            // txtukupno
            // 
            this.txtukupno.Location = new System.Drawing.Point(393, 71);
            this.txtukupno.Name = "txtukupno";
            this.txtukupno.Size = new System.Drawing.Size(195, 20);
            this.txtukupno.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Angebot Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "PLZ";
            // 
            // txtracun
            // 
            this.txtracun.Location = new System.Drawing.Point(117, 71);
            this.txtracun.Name = "txtracun";
            this.txtracun.Size = new System.Drawing.Size(195, 20);
            this.txtracun.TabIndex = 20;
            // 
            // txtgrad
            // 
            this.txtgrad.Location = new System.Drawing.Point(117, 45);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(195, 20);
            this.txtgrad.TabIndex = 17;
            // 
            // txtplz
            // 
            this.txtplz.Location = new System.Drawing.Point(393, 45);
            this.txtplz.Name = "txtplz";
            this.txtplz.Size = new System.Drawing.Size(195, 20);
            this.txtplz.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbOpis);
            this.groupBox2.Location = new System.Drawing.Point(681, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beschreibung";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(281, 87);
            this.rtbOpis.TabIndex = 22;
            this.rtbOpis.Text = "";
            this.rtbOpis.TextChanged += new System.EventHandler(this.rtbOpis_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDatum);
            this.groupBox3.Controls.Add(this.txtadresafirme);
            this.groupBox3.Controls.Add(this.txtImeFirmeNase);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(974, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unsere Daten";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(103, 94);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(100, 20);
            this.dtpDatum.TabIndex = 29;
            this.dtpDatum.Value = new System.DateTime(2017, 12, 21, 14, 18, 30, 0);
            // 
            // txtadresafirme
            // 
            this.txtadresafirme.Location = new System.Drawing.Point(103, 42);
            this.txtadresafirme.Name = "txtadresafirme";
            this.txtadresafirme.Size = new System.Drawing.Size(100, 20);
            this.txtadresafirme.TabIndex = 28;
            this.txtadresafirme.Text = "Trg Slobode 16";
            // 
            // txtImeFirmeNase
            // 
            this.txtImeFirmeNase.Location = new System.Drawing.Point(103, 68);
            this.txtImeFirmeNase.Name = "txtImeFirmeNase";
            this.txtImeFirmeNase.Size = new System.Drawing.Size(100, 20);
            this.txtImeFirmeNase.TabIndex = 27;
            this.txtImeFirmeNase.Text = "Enssol d.o.o.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Firmenname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Datum";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 16);
            this.maskedTextBox1.Mask = "(999) 000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.Text = "061820130";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Lime;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimi.Location = new System.Drawing.Point(48, 131);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(171, 35);
            this.btnSnimi.TabIndex = 2;
            this.btnSnimi.Text = "Daten Speichern";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnAngebotReport
            // 
            this.btnAngebotReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAngebotReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAngebotReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAngebotReport.Location = new System.Drawing.Point(18, 172);
            this.btnAngebotReport.Name = "btnAngebotReport";
            this.btnAngebotReport.Size = new System.Drawing.Size(227, 35);
            this.btnAngebotReport.TabIndex = 2;
            this.btnAngebotReport.Text = "Angebot ansehen und drucken";
            this.btnAngebotReport.UseVisualStyleBackColor = false;
            this.btnAngebotReport.Click += new System.EventHandler(this.btnAngebotReport_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(1031, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "Fenster Schließen";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnssFakutre.Properties.Resources.imageedit_5_4383488867;
            this.pictureBox1.Location = new System.Drawing.Point(294, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AngebotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAngebotReport);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAngebot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AngebotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AngebotForm";
            this.Load += new System.EventHandler(this.AngebotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngebot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngebot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnAngebotReport;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtfimra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtukupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtracun;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.TextBox txtplz;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtImeFirmeNase;
        private System.Windows.Forms.TextBox txtadresafirme;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}