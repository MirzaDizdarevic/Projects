namespace EnssFakutre
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnRechnung = new System.Windows.Forms.Button();
            this.btnPrijedlog = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnRechnung
            // 
            this.btnRechnung.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnRechnung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechnung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRechnung.ForeColor = System.Drawing.Color.Lime;
            this.btnRechnung.Location = new System.Drawing.Point(310, 245);
            this.btnRechnung.Name = "btnRechnung";
            this.btnRechnung.Size = new System.Drawing.Size(90, 37);
            this.btnRechnung.TabIndex = 0;
            this.btnRechnung.Text = "Rechnung";
            this.btnRechnung.UseVisualStyleBackColor = false;
            this.btnRechnung.Click += new System.EventHandler(this.btnRechnung_Click);
            // 
            // btnPrijedlog
            // 
            this.btnPrijedlog.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnPrijedlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijedlog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijedlog.ForeColor = System.Drawing.Color.Red;
            this.btnPrijedlog.Location = new System.Drawing.Point(406, 245);
            this.btnPrijedlog.Name = "btnPrijedlog";
            this.btnPrijedlog.Size = new System.Drawing.Size(95, 37);
            this.btnPrijedlog.TabIndex = 0;
            this.btnPrijedlog.Text = "Angebot";
            this.btnPrijedlog.UseVisualStyleBackColor = false;
            this.btnPrijedlog.Click += new System.EventHandler(this.btnPrijedlog_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(738, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnssFakutre.Properties.Resources.imageedit_5_4383488867;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(783, 294);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnPrijedlog);
            this.Controls.Add(this.btnRechnung);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechnung;
        private System.Windows.Forms.Button btnPrijedlog;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}