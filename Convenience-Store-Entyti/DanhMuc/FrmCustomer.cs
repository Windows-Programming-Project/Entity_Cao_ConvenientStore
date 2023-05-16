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
    public partial class FrmCustomer : Form
    {
        #region global Var
        BLLoyalCustomers dbCustomer = new BLLoyalCustomers();
        string err;
        bool Add;
        #endregion
        public FrmCustomer()
        {
            InitializeComponent();
        }

        void LoadDataCustomer()
        {
            try
            {
                // push on data GRV
                dgvCustomer.DataSource = dbCustomer.TakeLoyalCustomers();
                // chang size table
                dgvCustomer.AutoResizeColumns();
                //
                dgvCustomer_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCustomer.CurrentCell.RowIndex;
            txtIDCTM.Text = dgvCustomer.Rows[r].Cells[0].Value.ToString();
            txtNameCTM.Text = dgvCustomer.Rows[r].Cells[1].Value.ToString();
            txtTotalPayCTM.Text = dgvCustomer.Rows[r].Cells[2].Value.ToString();
            txtPhoneCTM.Text = dgvCustomer.Rows[r].Cells[3].Value.ToString();

        }
        #region button Customer
        private void btnAddCTM_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLLoyalCustomers blCTM = new BLLoyalCustomers();
                   // blCTM.AddLoyalCustomers(txtIDCTM.Text, txtNameCTM.Text, Int32.Parse(txtTotalPayCTM.Text), txtPhoneCTM.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataCustomer();
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
                BLLoyalCustomers blCTM = new BLLoyalCustomers();
              //  blCTM.AddLoyalCustomers(txtIDCTM.Text, txtNameCTM.Text, Int32.Parse(txtTotalPayCTM.Text), txtPhoneCTM.Text, ref err);
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Add Successfully!");
                }
            }
            LoadDataCustomer();
           
        }

        private void btnChangedCTM_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLLoyalCustomers blCTM = new BLLoyalCustomers();
                  //  blCTM.UpdateLoyalCustomers(txtIDCTM.Text, txtNameCTM.Text, Int32.Parse(txtTotalPayCTM.Text), txtPhoneCTM.Text, ref err);
                    LoadDataCustomer();
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
                    MessageBox.Show("Error Updating EMP!");
                }
            }
            else
            {
                BLLoyalCustomers blCTM = new BLLoyalCustomers();
               // blCTM.UpdateLoyalCustomers(txtIDCTM.Text, txtNameCTM.Text, Int32.Parse(txtTotalPayCTM.Text), txtPhoneCTM.Text, ref err);
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Add Successfully!");
                }
            }
            LoadDataCustomer();
          
        }

        private void btnDeleteCTM_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    BLLoyalCustomers blCTM = new BLLoyalCustomers();
                    blCTM.DeleteLoyalCustomers(txtIDCTM.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataCustomer();
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
                BLLoyalCustomers blCTM = new BLLoyalCustomers();
                blCTM.DeleteLoyalCustomers(txtIDCTM.Text, ref err);
                if (err != null && Add == false)
                {
                    MessageBox.Show(err.ToString());
                }
                else
                {
                    MessageBox.Show("Add Successfully!");
                }
            }
            LoadDataCustomer();
           
        }

        private void btnReloadCTM_Click(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }

        private void btnExitCTM_Click(object sender, EventArgs e)
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
