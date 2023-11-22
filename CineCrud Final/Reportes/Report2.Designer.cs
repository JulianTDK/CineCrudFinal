namespace Reportes
{
    partial class Report2
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
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cINEDataSet1 = new Reportes.CINEDataSet1();
            this.sppeliculasvistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_peliculas___vistasTableAdapter = new Reportes.CINEDataSet1TableAdapters.sp_peliculas___vistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sppeliculasvistasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sppeliculasvistasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Rep2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 427);
            this.reportViewer1.TabIndex = 1;
            // 
            // cINEDataSet1
            // 
            this.cINEDataSet1.DataSetName = "CINEDataSet1";
            this.cINEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sppeliculasvistasBindingSource
            // 
            this.sppeliculasvistasBindingSource.DataMember = "sp_peliculas_+_vistas";
            this.sppeliculasvistasBindingSource.DataSource = this.cINEDataSet1;
            // 
            // sp_peliculas___vistasTableAdapter
            // 
            this.sp_peliculas___vistasTableAdapter.ClearBeforeFill = true;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "Report2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sppeliculasvistasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CINEDataSet1 cINEDataSet1;
        private System.Windows.Forms.BindingSource sppeliculasvistasBindingSource;
        private CINEDataSet1TableAdapters.sp_peliculas___vistasTableAdapter sp_peliculas___vistasTableAdapter;
    }
}