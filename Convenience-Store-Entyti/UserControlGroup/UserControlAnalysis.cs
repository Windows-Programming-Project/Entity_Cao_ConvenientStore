﻿using Convenience_Store_Entyti.BS_Layer;
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
    public partial class UserControlAnalysis : UserControl
    {
        public UserControlAnalysis()
        {
            InitializeComponent();
        }
        #region global Var
        BLEmployee db = new BLEmployee();
        BLProduct bLProduct = new BLProduct();
        BLLoyalCustomers BLLoyalCustomers = new BLLoyalCustomers();
        string err;
        bool Add;
        #endregion
        void LoadData(DataTable data )
        {
            try
            {   
                // push on data GRV
                dgvShowAnalysis.DataSource = data;
                // chang size table
                dgvShowAnalysis.AutoResizeColumns();
   
                Add = true;
            }
            catch
            {
                //  MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        void LoadDataProductM()
        {
            try
            {
                // push on data GRV
               // dgvShowAnalysis.DataSource = bLProduct.GetLeastFavoriteProducts();
                dgvShowAnalysis.DataSource = bLProduct.GetMostFavoriteProducts();
                // chang size table
                dgvShowAnalysis.AutoResizeColumns();

                Add = true;
            }
            catch
            {
                //  MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        void LoadDataProductL()
        {
            try
            {
                // push on data GRV
                 dgvShowAnalysis.DataSource = bLProduct.GetLeastFavoriteProducts();
                //dgvShowAnalysis.DataSource = bLProduct.GetMostFavoriteProducts();
                // chang size table
                dgvShowAnalysis.AutoResizeColumns();

                Add = true;
            }
            catch
            {
                //  MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        void LoadDataCustomer()
        {
            try
            {
                // push on data GRV
                  dgvShowAnalysis.DataSource = BLLoyalCustomers.GetLoyalCustomerMostProducts();
                // chang size table
                dgvShowAnalysis.AutoResizeColumns();

                Add = true;
            }
            catch
            {
                //  MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void btEmployee_Diligent_Click(object sender, EventArgs e)
        {
            
            string monthText = tbGetInforAna.Text;
            DateTime month;

            if (DateTime.TryParse(monthText, out month))
            {
                LoadData(db.GetMostDiligentEmployees(month));
            }
            else
            {
                // Parsing failed, handle the error or provide a default value
                // In this case, you may choose to display an error message to the user
                MessageBox.Show("Invalid month format. Please enter the month in yyyy-MM format.");
            }

            
        }

        private void btnView5productOntop_Click(object sender, EventArgs e)
        {
            LoadDataProductM();
        }

        private void btnEMPhightIncome_Click(object sender, EventArgs e)
        {
            string monthText = tbGetInforAna.Text;
            DateTime month;

            if (DateTime.TryParse(monthText, out month))
            {
                LoadData(db.GetHighestIncomeEmployees(month));
            }
            else
            {
                // Parsing failed, handle the error or provide a default value
                // In this case, you may choose to display an error message to the user
                MessageBox.Show("Invalid month format. Please enter the month in yyyy-MM format.");
            }
           
        }

        private void btnSearchCTMbuy_Click(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }

        private void btProductsaleLest_Click(object sender, EventArgs e)
        {
            LoadDataProductL();
        }
    }
}
