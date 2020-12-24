namespace uretim_ve_imalat
{
    partial class Form3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.hammaddeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vtDataSet = new uretim_ve_imalat.vtDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hammaddeTableAdapter = new uretim_ve_imalat.vtDataSetTableAdapters.hammaddeTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.urunstokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunstokTableAdapter = new uretim_ve_imalat.vtDataSetTableAdapters.urunstokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hammaddeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunstokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hammaddeBindingSource
            // 
            this.hammaddeBindingSource.DataMember = "hammadde";
            this.hammaddeBindingSource.DataSource = this.vtDataSet;
            // 
            // vtDataSet
            // 
            this.vtDataSet.DataSetName = "vtDataSet";
            this.vtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hammaddeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "uretim_ve_imalat.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // hammaddeTableAdapter
            // 
            this.hammaddeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.urunstokBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "uretim_ve_imalat.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(25, 295);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(800, 250);
            this.reportViewer2.TabIndex = 1;
            // 
            // urunstokBindingSource
            // 
            this.urunstokBindingSource.DataMember = "urunstok";
            this.urunstokBindingSource.DataSource = this.vtDataSet;
            // 
            // urunstokTableAdapter
            // 
            this.urunstokTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 574);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üretim ve İmalat Otomasyonu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hammaddeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunstokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hammaddeBindingSource;
        private vtDataSet vtDataSet;
        private vtDataSetTableAdapters.hammaddeTableAdapter hammaddeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource urunstokBindingSource;
        private vtDataSetTableAdapters.urunstokTableAdapter urunstokTableAdapter;
    }
}