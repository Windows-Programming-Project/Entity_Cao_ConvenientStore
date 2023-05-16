using Convenience_Store_Entyti.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Convenience_Store_Entyti.DanhMuc
{
    public partial class UserControlOrder : System.Windows.Forms.UserControl
    {

        public UserControlOrder()
        {
            InitializeComponent();
        }
        #region global Var
        BLProduct dbProduct = new BLProduct();
        BLInvoice  dbInvoice = new BLInvoice();
        BLInvoice_Detail dbInvoice_Detail = new BLInvoice_Detail();
        bool Add;
        string err;
        string invoiceID = null;
        #endregion
        void LoadDataMenu()
        {
            try
            {
                // push data
                dgvMenu.DataSource = dbProduct.TakeProduct();
                // chang size table
                dgvMenu.AutoResizeColumns();
                //
                dgvMenu_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        void LoadDataDetail_order()
        {
            try
            {
                // push data
                dgvDetail_order.DataSource = dbInvoice_Detail.TakeInvoice_Detail_order(invoiceID);
                // chang size table
                dgvDetail_order.AutoResizeColumns();
                //
                dgvDetail_order_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                // MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMenu.CurrentCell.RowIndex;
            txtProduct_order.Text = dgvMenu.Rows[r].Cells[0].Value.ToString();
        }

        private void dgvDetail_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDetail_order.CurrentCell.RowIndex;
            txtProduct_order.Text = dgvDetail_order.Rows[r].Cells[0].Value.ToString();
        }
    
        #region Button
        private void btnAddInvoice_order_Click(object sender, EventArgs e)
        {
            try
            {
                BLInvoice dbinvoice = new BLInvoice();
                BLLoyalCustomers dbCustomer = new BLLoyalCustomers();
                string cID = dbCustomer.GetCustomerIdByPhoneNumber(txtCTMPhone_order.Text);
                int IID = dbInvoice.CountInvoiceIDs() + 1;
                float total = 0;
                DateTime date = DateTime.Now;
                invoiceID = IID.ToString();
                string err = string.Empty;
                bool result = dbInvoice.AddInvoice(invoiceID, txtIDEMP_order.Text,cID, date, total, total, ref err);

                if (result)
                {
                    LoadDataDetail_order();
                    LoadDataMenu();
                }
                else
                {
                    MessageBox.Show("An error occurred: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while updating the entries.";

                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nInner Exception: " + ex.InnerException.Message;
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFind_order_Click(object sender, EventArgs e)
        {
            string productName = txtNameFind_product.Text; 
            BLProduct dbProduct = new BLProduct();
            DataTable productTable = dbProduct.FindProduct(productName);
            dgvMenu.DataSource = productTable;
        }

        private void tbnUpdateInvoice_order_Click(object sender, EventArgs e)
        {
            try
            {
                BLInvoice dbInvoice = new BLInvoice();
                
                float total = 0;
                DateTime date = DateTime.Now;
                string err = string.Empty;
                bool result = dbInvoice.UpdateInvoice(invoiceID, txtIDEMP_order.Text, txtCTMPhone_order.Text, date, ref err);

                if (result)
                {
                    LoadDataDetail_order();
                    LoadDataMenu();
                }
                else
                {
                    MessageBox.Show("An error occurred: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Update invoice
                result = dbInvoice.UpdateInvoice(invoiceID, txtIDEMP_order.Text, txtCTMPhone_order.Text, date,  ref err);

                if (result)
                {
                    // Update successful
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the invoice: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while updating the entries.";

                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nInner Exception: " + ex.InnerException.Message;
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_order_Click(object sender, EventArgs e)
        {
            try
            {
                BLInvoice_Detail dbInvoice = new BLInvoice_Detail();
                int amount = 1; // Replace with the desired amount
                float price = 0; // Replace with the desired price
                string err = string.Empty;

                bool result = dbInvoice.AddInvoice_Detail(invoiceID, txtProduct_order.Text, int.Parse(txtAmountP_order.Text), price, ref err);

                if (result)
                {
                    // Invoice detail added successfully
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the invoice detail: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while adding the invoice detail.";

                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nInner Exception: " + ex.InnerException.Message;
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataDetail_order();
        }

        #endregion

        private void UserControlOrder_Load(object sender, EventArgs e)
        {
            LoadDataDetail_order();
            LoadDataMenu();
        }

        private void btnReloadMenu_order_Click(object sender, EventArgs e)
        {
            LoadDataMenu();
        }

        private void txtIDEMP_order_TextChanged(object sender, EventArgs e)
        {
            lbEmpID_Order.Visible = false;
        }

        private void txtCTMPhone_order_TextChanged(object sender, EventArgs e)
        {
            lbCustomerPhone_order.Visible = false;
        }

        private void txtProduct_order_TextChanged(object sender, EventArgs e)
        {
            lbProduct_order.Visible = false;
        }

        private void txtAmountP_order_TextChanged(object sender, EventArgs e)
        {
            lbAmountP_order.Visible = false;
        }
    }
}
