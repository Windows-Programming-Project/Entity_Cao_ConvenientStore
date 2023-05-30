namespace Convenience_Store_Entyti
{
    partial class FormReport
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
            this.convenienceStoreManagementDataSet1 = new Convenience_Store_Entyti.ConvenienceStoreManagementDataSet();
            this.fNTotalSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fN_TotalSalaryTableAdapter = new Convenience_Store_Entyti.ConvenienceStoreManagementDataSetTableAdapters.FN_TotalSalaryTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.convenienceStoreManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNTotalSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEmpSalary";
            reportDataSource1.Value = this.fNTotalSalaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Convenience_Store_Entyti.Report.ReportSalary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1406, 554);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // convenienceStoreManagementDataSet1
            // 
            this.convenienceStoreManagementDataSet1.DataSetName = "ConvenienceStoreManagementDataSet";
            this.convenienceStoreManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNTotalSalaryBindingSource
            // 
            this.fNTotalSalaryBindingSource.DataMember = "FN_TotalSalary";
            this.fNTotalSalaryBindingSource.DataSource = this.convenienceStoreManagementDataSet1;
            // 
            // fN_TotalSalaryTableAdapter
            // 
            this.fN_TotalSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Convenience_Store_Entyti.BS_Layer.Order);
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataSource = typeof(Convenience_Store_Entyti.BS_Layer.detail_order);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.convenienceStoreManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNTotalSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ConvenienceStoreManagementDataSet convenienceStoreManagementDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private System.Windows.Forms.BindingSource fNTotalSalaryBindingSource;
        private ConvenienceStoreManagementDataSet convenienceStoreManagementDataSet1;
        private ConvenienceStoreManagementDataSetTableAdapters.FN_TotalSalaryTableAdapter fN_TotalSalaryTableAdapter;
    }
}