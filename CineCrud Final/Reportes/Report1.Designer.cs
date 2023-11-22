namespace Reportes
{
    partial class Report1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.cINEDataSet = new Reportes.CINEDataSet();
            this.sppeliculasvistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_peliculas___vistasTableAdapter = new Reportes.CINEDataSetTableAdapters.sp_peliculas___vistasTableAdapter();
            this.cINEDataSet3 = new Reportes.CINEDataSet3();
            this.spcantcompxcliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_cant_comp_x_cliTableAdapter = new Reportes.CINEDataSet3TableAdapters.sp_cant_comp_x_cliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sppeliculasvistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcantcompxcliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spcantcompxcliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Rep1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cINEDataSet
            // 
            this.cINEDataSet.DataSetName = "CINEDataSet";
            this.cINEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sppeliculasvistasBindingSource
            // 
            this.sppeliculasvistasBindingSource.DataMember = "sp_peliculas_+_vistas";
            this.sppeliculasvistasBindingSource.DataSource = this.cINEDataSet;
            // 
            // sp_peliculas___vistasTableAdapter
            // 
            this.sp_peliculas___vistasTableAdapter.ClearBeforeFill = true;
            // 
            // cINEDataSet3
            // 
            this.cINEDataSet3.DataSetName = "CINEDataSet3";
            this.cINEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spcantcompxcliBindingSource
            // 
            this.spcantcompxcliBindingSource.DataMember = "sp_cant_comp_x_cli";
            this.spcantcompxcliBindingSource.DataSource = this.cINEDataSet3;
            // 
            // sp_cant_comp_x_cliTableAdapter
            // 
            this.sp_cant_comp_x_cliTableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report1";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sppeliculasvistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcantcompxcliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private CINEDataSet cINEDataSet;
        private System.Windows.Forms.BindingSource sppeliculasvistasBindingSource;
        private CINEDataSetTableAdapters.sp_peliculas___vistasTableAdapter sp_peliculas___vistasTableAdapter;
        private CINEDataSet3 cINEDataSet3;
        private System.Windows.Forms.BindingSource spcantcompxcliBindingSource;
        private CINEDataSet3TableAdapters.sp_cant_comp_x_cliTableAdapter sp_cant_comp_x_cliTableAdapter;
    }
}