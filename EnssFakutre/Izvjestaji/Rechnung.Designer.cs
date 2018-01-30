namespace EnssFakutre.Izvjestaji
{
    partial class Rechnung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnung));
            this.rptEnssolRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enssolDataSet = new EnssFakutre.EnssolDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptEnssolRacunTableAdapter = new EnssFakutre.EnssolDataSetTableAdapters.rptEnssolRacunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptEnssolRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enssolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptEnssolRacunBindingSource
            // 
            this.rptEnssolRacunBindingSource.DataMember = "rptEnssolRacun";
            this.rptEnssolRacunBindingSource.DataSource = this.enssolDataSet;
            // 
            // enssolDataSet
            // 
            this.enssolDataSet.DataSetName = "EnssolDataSet";
            this.enssolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Enssol";
            reportDataSource1.Value = this.rptEnssolRacunBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EnssFakutre.Izvjestaji.Rechnung1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(835, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptEnssolRacunTableAdapter
            // 
            this.rptEnssolRacunTableAdapter.ClearBeforeFill = true;
            // 
            // Rechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 611);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rechnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnung";
            this.Load += new System.EventHandler(this.Rechnung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptEnssolRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enssolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptEnssolRacunBindingSource;
        private EnssolDataSet enssolDataSet;
        private EnssolDataSetTableAdapters.rptEnssolRacunTableAdapter rptEnssolRacunTableAdapter;
    }
}