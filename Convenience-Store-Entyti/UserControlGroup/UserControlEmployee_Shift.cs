using Convenience_Store_Entyti.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Entyti.UserControlGroup
{
    public partial class UserControlEmployee_Shift : UserControl
    {
        BLEmployee_Shift dbEmpShift = new BLEmployee_Shift();
        BLEmployee dbEmp = new BLEmployee();
        public static string DateMonth = "";
        string err;
        bool Add;
        public UserControlEmployee_Shift()
        {
            InitializeComponent();
        }
        void LoadDataEMPShift()
        {
            try
            {
                DateMonth = tbMonth.Text;
                // push data
                dgvEmpShift.DataSource = dbEmpShift.TakeEmployeeShift();
                // chang size table
                dgvEmpShift.AutoResizeColumns();
                //
                dgvEmpShift_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }

        void LoadDataShift()
        {
            try
            {
                DateMonth = tbMonth.Text;
                // push data
                dgvEmpShift.DataSource = dbEmpShift.TakeShift();
                // chang size table
                dgvEmpShift.AutoResizeColumns();
                //
                dgvEmpShift_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }


        void LoadDataEMPtotalpay()
        {
            try
            {
                string monthText = tbMonth.Text;
                DateMonth = tbMonth.Text;
                DateTime month;

                if (DateTime.TryParse(monthText, out month))
                {
                    // Parsing successful, month variable now holds the DateTime value based on the text input
                    //DateTime month = new DateTime(2022,3, 1);
                    // push data
                    dgvEmpShift.DataSource = dbEmp.GetEmployeePayroll(month);
                    // chang size table
                    dgvEmpShift.AutoResizeColumns();
                    //
                    dgvEmpShift_CellContentClick(null, null);
                    Add = true;
                }
                else
                {
                    // Parsing failed, handle the error or provide a default value
                    // In this case, you may choose to display an error message to the user
                    MessageBox.Show("Invalid month format. Please enter the month in yyyy-MM format.");
                }
                
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void UserControlEmployee_Shift_Load(object sender, EventArgs e)
        {
            LoadDataEMPShift();
        }

        private void dgvEmpShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvEmpShift.CurrentCell.RowIndex;
           tbShiftID.Text = dgvEmpShift.Rows[r].Cells[0].Value.ToString();
            tbShiftStart.Text = dgvEmpShift.Rows[r].Cells[1].Value.ToString();
            tbShiftEnd.Text = dgvEmpShift.Rows[r].Cells[2].Value.ToString();
        }
        private void dgvEmpShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculateSalaryEmp_Click(object sender, EventArgs e)
        {
            LoadDataEMPtotalpay();
        }
        FormReport newreport = new FormReport();
        private void btEmpSalaryReport_Click(object sender, EventArgs e)
        {
            FormReport.path = "Convenience_Store_Entyti.Report.ReportSalary.rdlc";
            newreport.LoadEmployeeSalaryData();
            newreport.ShowDialog();
        }

        private void btEmpShiftreport_Click(object sender, EventArgs e)
        {
            FormReport.path = "Convenience_Store_Entyti.Report.ReportEmpShift.rdlc";
            newreport.LoadEmployeeShiftData();
            newreport.ShowDialog();
        }

        private void btViewShift_Click(object sender, EventArgs e)
        {
            LoadDataShift();
        }
        

        private void btAddShift_Click(object sender, EventArgs e)
        {
            try
            {   
                string shID = tbShiftID.Text;
                TimeSpan? startTime = TimeSpan.Parse(tbShiftStart.Text);
                TimeSpan? endTime = TimeSpan.Parse(tbShiftEnd.Text);

                string errorMessage = string.Empty;
                if (dbEmpShift.AddShift(shID, startTime, endTime, ref errorMessage))
                {
                    LoadDataShift();
                    MessageBox.Show("Shift added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add shift.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void btUpdateShift_Click(object sender, EventArgs e)
        {
            try
            {
                string shID = tbShiftID.Text;
                TimeSpan? startTime = TimeSpan.Parse(tbShiftStart.Text);
                TimeSpan? endTime = TimeSpan.Parse(tbShiftEnd.Text);

                string errorMessage = string.Empty;
                if (dbEmpShift.UpdateShift(shID, startTime, endTime, ref errorMessage))
                {
                    LoadDataShift();
                    MessageBox.Show("Shift updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update shift.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void btDeleteShift_Click(object sender, EventArgs e)
        {
            try
            {
                string shID = tbShiftID.Text;

                string errorMessage = string.Empty;
                if (dbEmpShift.DeleteShift(shID, ref errorMessage))
                {
                    LoadDataShift();
                    MessageBox.Show("Shift deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete shift.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

       
    }
}
