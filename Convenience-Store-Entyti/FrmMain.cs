using Convenience_Store_Entyti.DanhMuc;
using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Convenience_Store_Entyti
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void ptbShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            // Create an instance of UserControlOrder
            UserControlOrder userControlOrder = new UserControlOrder();

            // Set the Dock property to fill the panel
            userControlOrder.Dock = DockStyle.Fill;

            // Clear existing controls from the panel
            panelShowOnMainForm.Controls.Clear();

            // Add the UserControlOrder to the panel
            panelShowOnMainForm.Controls.Add(userControlOrder);
        }

        private void btEmployeeManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = true;
            btEmployee_Shift.Visible = true;
            // Create an instance of UserControlOrder
            FirstUserControlEmp userControlEmployee = new FirstUserControlEmp();

            // Set the Dock property to fill the panel
            userControlEmployee.Dock = DockStyle.Fill;

            // Clear existing controls from the panel
            panelShowOnMainForm.Controls.Clear();

            // Add the UserControlOrder to the panel
            panelShowOnMainForm.Controls.Add(userControlEmployee);

        }

        private void btEmployee_Shift_Click(object sender, EventArgs e)
        {
            UserControlEmployee_Shift userControlEmployee_Shift = new UserControlEmployee_Shift();

            // Set the Dock property to fill the panel
            userControlEmployee_Shift.Dock = DockStyle.Fill;

            // Clear existing controls from the panel
            panelShowOnMainForm.Controls.Clear();

            // Add the UserControlOrder to the panel
            panelShowOnMainForm.Controls.Add(userControlEmployee_Shift);
        }

        private void btEmployee_late_Click(object sender, EventArgs e)
        {
            UserControlEmployeeLate userControlEmployeeLate = new UserControlEmployeeLate();

            // Set the Dock property to fill the panel
            userControlEmployeeLate.Dock = DockStyle.Fill;

            // Clear existing controls from the panel
            panelShowOnMainForm.Controls.Clear();

            // Add the UserControlOrder to the panel
            panelShowOnMainForm.Controls.Add(userControlEmployeeLate);
        }

        private void btCustomerManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlCustomer userControlCustomer = new UserControlCustomer();
            userControlCustomer.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControlCustomer);
        }

        private void btStockManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlStock userControlStock = new UserControlStock();
            userControlStock.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControlStock);
        }

        private void btTypeManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlType userControl = new UserControlType();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btSupplierManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlSupplier userControl = new UserControlSupplier();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btProductManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlProduct userControl = new UserControlProduct();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btManuafacture_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlManuafacturer userControl = new UserControlManuafacturer();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btInvoice_Detail_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlInvoice_Detail userControl = new UserControlInvoice_Detail();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlInvoice userControl = new UserControlInvoice();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btAccountManagement_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlAcountLogin userControl = new UserControlAcountLogin();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlAnalysis userControl = new UserControlAnalysis();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            btEmployee_late.Visible = false;
            btEmployee_Shift.Visible = false;
            UserControlRanks userControl = new UserControlRanks();
            userControl.Dock = DockStyle.Fill;
            panelShowOnMainForm.Controls.Clear();
            panelShowOnMainForm.Controls.Add(userControl);
        }
    }
}
