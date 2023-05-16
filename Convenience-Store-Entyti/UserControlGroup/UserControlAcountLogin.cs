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
    public partial class UserControlAcountLogin : UserControl
    {
        public UserControlAcountLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void tbUserLogin_TextChanged(object sender, EventArgs e)
        {
            lbUserLogin.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbPassLogin.Visible = false;
        }
        bool verif()
        {
            if (tbPassword.Text.Trim() == "" || tbUserLogin.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Please enter your account and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rdBEmployeeFull.Checked == false && rdBEmpPart.Checked == false && rdBManager.Checked == false )
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    BLEmployee dbEmployee = new BLEmployee();
                    string role = "";
                    if (rdBEmployeeFull.Checked == true)
                    {
                        role = "FulltimeStaff";
                    }
                    if (rdBEmpPart.Checked == true)
                    {
                        role = "ParttimeStaff";
                    }
                    if (rdBManager.Checked == true)
                    {
                        role = "Manager";
                    }
                    bool isValidCredentials = dbEmployee.CheckAccountCredentials(tbUserLogin.Text, tbPassword.Text, role);

                    if (isValidCredentials)
                    {
                        // Credentials are valid
                        MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials or role selection!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }
    }
}
