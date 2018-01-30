namespace EnssFakutre.Izvjestaji
{
    partial class Angebot
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angebot));
            this.rptEnssolPredRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enssolDataSet = new EnssFakutre.EnssolDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptEnssolPredRacunTableAdapter = new EnssFakutre.EnssolDataSetTableAdapters.rptEnssolPredRacunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptEnssolPredRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enssolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptEnssolPredRacunBindingSource
            // 
            this.rptEnssolPredRacunBindingSource.DataMember = "rptEnssolPredRacun";
            this.rptEnssolPredRacunBindingSource.DataSource = this.enssolDataSet;
            // 
            // enssolDataSet
            // 
            this.enssolDataSet.DataSetName = "EnssolDataSet";
            this.enssolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Enssol2";
            reportDataSource1.Value = this.rptEnssolPredRacunBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EnssFakutre.Izvjestaji.Angebot1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptEnssolPredRacunTableAdapter
            // 
            this.rptEnssolPredRacunTableAdapter.ClearBeforeFill = true;
            // 
            // Angebot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 562);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Angebot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angebot";
            this.Load += new System.EventHandler(this.Angebot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptEnssolPredRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enssolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptEnssolPredRacunBindingSource;
        private EnssolDataSet enssolDataSet;
        private EnssolDataSetTableAdapters.rptEnssolPredRacunTableAdapter rptEnssolPredRacunTableAdapter;
    }
}