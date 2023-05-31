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
using Convenience_Store_Entyti.RJControl;
namespace Convenience_Store_Entyti.DanhMuc
{
    public partial class FirstUserControlEmp : System.Windows.Forms.UserControl
    {

        #region global Var
        BLEmployee dbEmployee = new BLEmployee();
        BLEmployee_Shift dbEmpShift = new BLEmployee_Shift();
        string err;
        bool Add;
        #endregion

        public FirstUserControlEmp()
        {
            InitializeComponent();
        }

        void LoadDataEMP()
        {
            try
            {
                // push data
                dgvEMPLOYEE.DataSource = dbEmployee.TakeEmployee();
                // chang size table
                dgvEMPLOYEE.AutoResizeColumns();
                //
                dgvEMPLOYEE_CellClick(null, null);
                Add = true;
            }
            catch
            {
               // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dgvEMPLOYEE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvEMPLOYEE.CurrentCell.RowIndex;
            txtIDEmp.Text = dgvEMPLOYEE.Rows[r].Cells[0].Value.ToString();
            txtNameEMP.Text = dgvEMPLOYEE.Rows[r].Cells[1].Value.ToString();
            txtDateOfBirthEMP.Text = dgvEMPLOYEE.Rows[r].Cells[2].Value.ToString();
            txtGenderEMP.Text = dgvEMPLOYEE.Rows[r].Cells[3].Value.ToString();
            txtPhoneEMP.Text = dgvEMPLOYEE.Rows[r].Cells[4].Value.ToString();
            txtAddressEMP.Text = dgvEMPLOYEE.Rows[r].Cells[5].Value.ToString();
            txtPositionEMP.Text = dgvEMPLOYEE.Rows[r].Cells[6].Value.ToString();
            txtSalaryEMP.Text = dgvEMPLOYEE.Rows[r].Cells[7].Value.ToString();
            txtUserNameEmp.Text = dgvEMPLOYEE.Rows[r].Cells[8].Value.ToString();
            txtPasswordAccountEmp.Text = dgvEMPLOYEE.Rows[r].Cells[9].Value.ToString();
        }
        private void FirstUserControlEmp_Load(object sender, EventArgs e)
        {
            LoadDataEMP();
           
        }

        #region button employee
        private void btnReloadEMP_Click_1(object sender, EventArgs e)
        {
            LoadDataEMP();
        }
       
        private void btnExitEMP_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEMP_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLEmployee blEMP = new BLEmployee();
                    Add = blEMP.AddEmployee(txtIDEmp.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateOfBirthEMP.Text), Convert.ToBoolean(txtGenderEMP.Text), txtPhoneEMP.Text, txtAddressEMP.Text, txtPositionEMP.Text, Int32.Parse(txtSalaryEMP.Text),txtUserNameEmp.Text,txtPasswordAccountEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                  
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
                // Thực hiện lệnh 
                BLEmployee blEMP = new BLEmployee();
                blEMP.AddEmployee(txtIDEmp.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateOfBirthEMP.Text), Convert.ToBoolean(txtGenderEMP.Text), txtPhoneEMP.Text, txtAddressEMP.Text, txtPositionEMP.Text, Int32.Parse(txtSalaryEMP.Text), txtUserNameEmp.Text, txtPasswordAccountEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
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
            LoadDataEMP();

        }

        private void btnChangedEMP_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLEmployee blEMP = new BLEmployee();
                    blEMP.UpdateEmployee(txtIDEmp.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateOfBirthEMP.Text), Convert.ToBoolean(txtGenderEMP.Text), txtPhoneEMP.Text, txtAddressEMP.Text, txtPositionEMP.Text, Int32.Parse(txtSalaryEMP.Text), txtUserNameEmp.Text, txtPasswordAccountEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataEMP();
                    if (err != null && Add == false)
                    {
                        MessageBox.Show(err.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Update Successfully!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error update EMP!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLEmployee blEMP = new BLEmployee();
                blEMP.UpdateEmployee(txtIDEmp.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateOfBirthEMP.Text), Convert.ToBoolean(txtGenderEMP.Text), txtPhoneEMP.Text, txtAddressEMP.Text, txtPositionEMP.Text, Int32.Parse(txtSalaryEMP.Text), txtUserNameEmp.Text, txtPasswordAccountEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Update Successfully!");
                }
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
        }

        private void btnDeleteEMP_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLEmployee blEMP = new BLEmployee();
                    blEMP.DeleteEmployee(txtIDEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataEMP();
                    if (err != null && Add == false)
                    {
                        MessageBox.Show(err.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Delete Successfully!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Delete EMP!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLEmployee blEMP = new BLEmployee();
                blEMP.DeleteEmployee(txtIDEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Delete Successfully!");
                }
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();

        }


        #endregion

        #region lable text 
        private void txtIDEmp_TextChanged(object sender, EventArgs e)
        {
            lbEmpID.Visible = false;
        }

        private void txtNameEMP_TextChanged(object sender, EventArgs e)
        {
            lbNameEMP.Visible = false;
        }

        private void txtPhoneEMP_TextChanged(object sender, EventArgs e)
        {
            lbPhoneEMP.Visible = false;
        }

        private void txtGenderEMP_TextChanged(object sender, EventArgs e)
        {
            lbGenderEMP.Visible = false;
        }

        private void txtUserNameEmp_TextChanged(object sender, EventArgs e)
        {
            lbUserNameAccount.Visible = false;
        }

        private void txtPasswordAccountEmp_TextChanged(object sender, EventArgs e)
        {
            lbPassword.Visible = false;
        }

        private void txtSalaryEMP_TextChanged(object sender, EventArgs e)
        {
            lbSalaryEMP.Visible = false;
        }

        private void txtPositionEMP_TextChanged(object sender, EventArgs e)
        {
            lbPositionEMP.Visible = false;
        }

        private void txtAddressEMP_TextChanged(object sender, EventArgs e)
        {
            lbAddressEMP.Visible = false;
        }

        private void txtDateOfBirthEMP_TextChanged(object sender, EventArgs e)
        {
            lbDateofBirthEMP.Visible = false;
        }

        #endregion

        private void btFindEMP_Click(object sender, EventArgs e)
        {
            dgvEMPLOYEE.DataSource = dbEmployee.FindEmployeesByName(txtFindEMP.Text);
            // chang size table
            dgvEMPLOYEE.AutoResizeColumns();
            
          
        }

        
    }
}
