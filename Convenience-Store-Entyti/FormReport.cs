using Convenience_Store_Entyti.BS_Layer;
using Convenience_Store_Entyti.UserControlGroup;
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
        public static string path = "";
        public FormReport()
        {
            InitializeComponent();
        }

        public void LoadEmployeeSalaryData()
        {

            BLEmployee bLEmployee = new BLEmployee();
            string monthText = UserControlEmployee_Shift.DateMonth;
            DateTime month;

            if (DateTime.TryParse(monthText, out month))
            {
                DataTable dataEmpPayroll_Sheet = bLEmployee.GetEmployeePayroll(month);
                ReportDataSource datasourceEmpPayroll_Sheet = new ReportDataSource("DataSetEmpSalaryMonth", dataEmpPayroll_Sheet);
                fNTotalSalaryBindingSource.DataSource = datasourceEmpPayroll_Sheet;
                this.reportViewer1.LocalReport.DataSources.Add(datasourceEmpPayroll_Sheet);
            }
            else
            {
                // Parsing failed, handle the error or provide a default value
                // In this case, you may choose to display an error message to the user
                MessageBox.Show("Invalid month format. Please enter the month in yyyy-MM format.");
            }
        }
        public void LoadEmployeeSalaryAnalysisData()
        {

            BLEmployee bLEmployee = new BLEmployee();
            string monthText = UserControlEmployee_Shift.DateMonth;
            DateTime month = DateTime.Now;

            
                DataTable dataEmpPayroll_Sheet = bLEmployee.GetEmployeePayrollAnalysis(month);
                ReportDataSource datasourceEmpPayroll_Sheet = new ReportDataSource("DataSetEmpSalaryAnalysis", dataEmpPayroll_Sheet);
                fNTotalSalaryBindingSource.DataSource = datasourceEmpPayroll_Sheet;
                this.reportViewer1.LocalReport.DataSources.Add(datasourceEmpPayroll_Sheet);
                
          
        }
        public void LoadEmployeeShiftData()
        {   
            
            BLEmployee_Shift bLEmployee_Shift = new BLEmployee_Shift();
            DataTable dataEmpShift = bLEmployee_Shift.TakeEmployeeShift();
            DataTable dataShift = bLEmployee_Shift.TakeShift();
            ReportDataSource datasourceEmpShift = new ReportDataSource("DataSetEmpShift", dataEmpShift);
            this.reportViewer1.LocalReport.DataSources.Add(datasourceEmpShift);
            ReportDataSource datasourceShift = new ReportDataSource("DataSetShift", dataShift);
            this.reportViewer1.LocalReport.DataSources.Add(datasourceShift);
            //employeeShiftBindingSource.DataSource = datasourceEmpShift;
        }

        public void LoadOrderData()
        {
            BLInvoice bLInvoice = new BLInvoice();
            string invoiceID = bLInvoice.CountInvoiceIDs() + "";
            DataTable dataOrder = bLInvoice.GetInvoiceTable(invoiceID);
            DataTable dataOrder_detail = bLInvoice.GetOrderDetailTable(invoiceID);
            ReportDataSource dataSourceOrder = new ReportDataSource("DataSetOrder", dataOrder);
            ReportDataSource dataSourceOrder_detail = new ReportDataSource("DataSetDetai_Order", dataOrder_detail);
            orderBindingSource.DataSource = dataOrder;
            detailorderBindingSource.DataSource = dataOrder_detail;
            this.reportViewer1.LocalReport.DataSources.Add(dataSourceOrder);
            this.reportViewer1.LocalReport.DataSources.Add(dataSourceOrder_detail);
        }
        private void FormReport_Load(object sender, EventArgs e)
        {

           //this.employee_ShiftTableAdapter.Fill(this.convenienceStoreManagementDataSet1.Employee_Shift);

            if (path == "Convenience_Store_Entyti.Report.ReportEmpShift.rdlc")
            {
                LoadEmployeeShiftData();
            }
            else if (path == "Convenience_Store_Entyti.Report.ReportOrder.rdlc")
            {
                LoadOrderData();
            }
            else if (path == "Convenience_Store_Entyti.Report.ReportSalary.rdlc")
            {
                LoadEmployeeSalaryData();
            }
            else if (path == "Convenience_Store_Entyti.Report.ReportEmpSalaryAnalysis.rdlc")
            {
                LoadEmployeeSalaryAnalysisData();
            }

            this.reportViewer1.LocalReport.ReportEmbeddedResource = path;
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.DataBindings.Clear();
        }
    }
}
