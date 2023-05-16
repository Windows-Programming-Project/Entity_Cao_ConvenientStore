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

namespace Convenience_Store_Entyti.UserControlGroup
{
    public partial class UserControlEmployee_Shift : UserControl
    {
        BLEmployee_Shift dbEmpShift = new BLEmployee_Shift();
        BLEmployee dbEmp = new BLEmployee();
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
        DateTime month = new DateTime(2022, 3, 1);
        void LoadDataEMPtotalpay()
        {
            try
            {
                // push data
                dgvEmpShift.DataSource = dbEmp.GetEmployeePayroll(month);
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
        private void UserControlEmployee_Shift_Load(object sender, EventArgs e)
        {
            LoadDataEMPShift();
        }

        private void dgvEmpShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculateSalaryEmp_Click(object sender, EventArgs e)
        {
            LoadDataEMPtotalpay();
        }
    }
}
