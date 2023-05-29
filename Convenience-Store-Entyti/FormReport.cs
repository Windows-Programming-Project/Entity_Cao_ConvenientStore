using Convenience_Store_Entyti.BS_Layer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Entyti
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {


           
            DateTime month = new DateTime(2023, 2, 1);
            BLEmployee bLEmployee = new BLEmployee();
            BLInvoice bLInvoice = new BLInvoice();
            DataTable data = bLEmployee.GetEmployeePayroll(month);
            string invoiceID = bLInvoice.CountInvoiceIDs() + "";
            DataTable dataOrder = bLInvoice.GetInvoiceTable(invoiceID);
            DataTable dataOrder_detail = bLInvoice.GetOrderDetailTable(invoiceID);
            //=====
            ReportDataSource dataSource = new ReportDataSource("DataSetEmpSalary", data);
            ReportDataSource dataSourceOrder = new ReportDataSource("DataSetOrder", dataOrder);
            ReportDataSource dataSourceOrder_detail = new ReportDataSource("DataSetDetai_Order", dataOrder_detail);
            orderBindingSource.DataSource = dataOrder;
            detailorderBindingSource.DataSource = dataOrder_detail;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.DataSources.Add(dataSourceOrder);
            this.reportViewer1.LocalReport.DataSources.Add(dataSourceOrder_detail);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Convenience_Store_Entyti.ReportManager.rdlc";

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.DataBindings.Clear();
        }
    }
}
