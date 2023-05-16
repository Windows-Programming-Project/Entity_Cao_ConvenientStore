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
    public partial class UserControlRanks : System.Windows.Forms.UserControl
    {
        public UserControlRanks()
        {
            InitializeComponent();
        }
        #region global Var
        BLRank db = new BLRank();
        string err;
        bool Add;
        #endregion
        void LoadData()
        {
            try
            {
                // push on data GRV
                dgvRank.DataSource = db.TakeRanks();
                // chang size table
                dgvRank.AutoResizeColumns();
                //
                dgvRank_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
              //  MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dgvRank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvRank.CurrentCell.RowIndex;
            tbRankName.Text = dgvRank.Rows[r].Cells[0].Value.ToString();
           tbrDiscount.Text = dgvRank.Rows[r].Cells[1].Value.ToString();

        }

        private void btAddRank_Click(object sender, EventArgs e)
        {
            try
            {
                string rankName = tbRankName.Text;
                float discount;
                float.TryParse(tbrDiscount.Text, out discount);

                BLRank blrank = new BLRank();
                string err = null;
                bool success = blrank.AddRanks(rankName, discount, ref err);

                if (success)
                {
                    MessageBox.Show("Rank added successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error adding rank: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding rank: " + ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string rankName = tbRankName.Text;
                float discount;
                float.TryParse(tbrDiscount.Text, out discount);

                BLRank blrank = new BLRank();
                string err = null;
                bool success = blrank.UpdateRanks(rankName, discount, ref err);
                if (success)
                {
                    MessageBox.Show("Rank updated successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error updating rank: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rank: " + ex.Message);
            }
        }

        private void btDeleteRank_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rankName = tbRankName.Text;
                BLRank blrank = new BLRank();
                string err = null;
                bool success = blrank.DeleteRanks(rankName, ref err);

                if (success)
                {
                    MessageBox.Show("Rank deleted successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error deleting rank: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting rank: " + ex.Message);
            }
        }

        private void btReloadRank_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
