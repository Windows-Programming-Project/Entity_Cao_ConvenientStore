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

namespace Convenience_Store_Entyti.DanhMuc
{
    public partial class FrmEmployee : Form
    {
        #region global Var
        BLEmployee dbEmployee = new BLEmployee();
        string err;
        bool Add;
        #endregion
        public FrmEmployee()
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
                dgvEMPLOYEE_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadDataEMP();
        }

        private void dgvEMPLOYEE_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        }
        #region button employee
        private void btnAddEMP_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLEmployee blEMP = new BLEmployee();
                    Add = blEMP.AddEmployee(txtIDEmp.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateOfBirthEMP.Text), Convert.ToBoolean(txtGenderEMP.Text), txtPhoneEMP.Text, txtAddressEMP.Text, txtPositionEMP.Text, Int32.Parse(txtSalaryEMP.Text), txtUserNameEmp.Text, txtPasswordAccountEmp.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataEMP();
                    // Thông báo 
                    if(err != null && Add == false)
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
                        MessageBox.Show("Add Successfully!");
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
                    MessageBox.Show("Add Successfully!");
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
                        MessageBox.Show("Add Successfully!");
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
                    MessageBox.Show("Add Successfully!");
                }
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
           
        }

        private void btnReloadEMP_Click(object sender, EventArgs e)
        {
            LoadDataEMP();
        }

        private void btnExitEMP_Click(object sender, EventArgs e)
        {

            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
        #endregion
    }
}
