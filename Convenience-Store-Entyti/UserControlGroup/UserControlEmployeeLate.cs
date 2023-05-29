using Convenience_Store_Entyti.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Entyti.UserControlGroup
{
    public partial class UserControlEmployeeLate : UserControl
    {
        #region global Var
        BLEmployeeLate dbEmployeeLate = new BLEmployeeLate();
        string err;
        bool Add;
        #endregion
        public UserControlEmployeeLate()
        {
            InitializeComponent();
        }

        public void LoadDataEMPlate()
        {
            try
            {
                // push data
                dgvEmpLate.DataSource = dbEmployeeLate.TakeEmployeeLate();
                // chang size table
                dgvEmpLate.AutoResizeColumns();
                //
                dgvEmpLate_CellClick(null, null);
                Add = true;
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dgvEmpLate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvEmpLate.CurrentCell.RowIndex;
            txtIDEmpLate.Text = dgvEmpLate.Rows[r].Cells[0].Value.ToString();
            txtStartTime.Text = dgvEmpLate.Rows[r].Cells[2].Value.ToString();
            txtShID.Text = dgvEmpLate.Rows[r].Cells[4].Value.ToString();
            txtEndTime.Text = dgvEmpLate.Rows[r].Cells[3].Value.ToString();
            txtEMPLateDate.Text = dgvEmpLate.Rows[r].Cells[1].Value.ToString();

        }

        private void btLoadEmpLate_Click(object sender, EventArgs e)
        {
            LoadDataEMPlate();
        }

        private void btAddEmpLate_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    Add = dbEmployeeLate.AddEmployeeLate(txtIDEmpLate.Text, DateTime.Parse(txtEMPLateDate.Text), TimeSpan.Parse(txtStartTime.Text), TimeSpan.Parse(txtEndTime.Text), txtShID.Text, ref err);
                    // Thông báo 
                    if (err != null && Add == false)
                    {
                        MessageBox.Show(err.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Add Successfully!");
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Adding EMP!");
                }
            }
            else
            {
                Add = dbEmployeeLate.AddEmployeeLate(txtIDEmpLate.Text, DateTime.Parse(txtEMPLateDate.Text), TimeSpan.Parse(txtStartTime.Text), TimeSpan.Parse(txtEndTime.Text), txtShID.Text, ref err);
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Add Successfully!");
                }
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMPlate();
        }

        private void btUpdateEmpLate_Click(object sender, EventArgs e)
        {
            try
            {
                string err = null;
                string eID = txtIDEmpLate.Text;
                DateTime lateDate = DateTime.Parse(txtEMPLateDate.Text);
                TimeSpan startTime = TimeSpan.Parse(txtStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);
                string shID = txtShID.Text;

                bool success = dbEmployeeLate.UpdateEmployeeLate(eID, lateDate, startTime, endTime, shID, ref err);

                if (success)
                {
                    MessageBox.Show("Employee Late updated successfully!");
                }
                else
                {
                    MessageBox.Show("Error updating Employee Late: " + err);
                }

                // Reload data on DataGridView
                LoadDataEMPlate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Employee Late: " + ex.Message);
            }
        }

        private void btDeleteEmpLate_Click(object sender, EventArgs e)
        {
            try
            {
                string err = null;
                string eID = txtIDEmpLate.Text;

                bool success = dbEmployeeLate.DeleteEmployeeLate(eID, ref err);

                if (success)
                {
                    MessageBox.Show("Employee Late deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Error deleting Employee Late: " + err);
                }

                // Reload data on DataGridView
                LoadDataEMPlate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Employee Late: " + ex.Message);
            }
        }
    }
}
