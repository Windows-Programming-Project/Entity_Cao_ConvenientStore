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
    public partial class UserControlInvoice_Detail : UserControl
    {
        public UserControlInvoice_Detail()
        {
            InitializeComponent();
        }
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLInvoice_Detail dbTY = new BLInvoice_Detail();
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvDETAIL.DataSource = dbTY.TakeInvoice_Detail();
                // Thay đổi độ rộng cột
                dgvDETAIL.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtIDI.ResetText();
                this.txtIDP.ResetText();
                this.txtdAmount.ResetText();
                this.txtdPrice.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvDETAIL_CellContentClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table DETAIL. Lỗi rồi!!!");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDETAIL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvDETAIL.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtIDI.Text = dgvDETAIL.Rows[r].Cells[0].Value.ToString();
            this.txtIDP.Text = dgvDETAIL.Rows[r].Cells[1].Value.ToString();
            this.txtdAmount.Text = dgvDETAIL.Rows[r].Cells[2].Value.ToString();
            this.txtdPrice.Text = dgvDETAIL.Rows[r].Cells[3].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtIDI.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtIDI.ResetText();
            this.txtIDP.ResetText();
            this.txtdAmount.ResetText();
            this.txtdPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txttID
            this.txtIDI.Focus();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvDETAIL_CellContentClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txttID
            this.txtIDI.Enabled = false;
            this.txtIDP.Enabled = false;
            this.txtdPrice.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLInvoice_Detail blDe = new BLInvoice_Detail();
                    blDe.AddInvoice_Detail(this.txtIDI.Text, this.txtIDP.Text, int.Parse(this.txtdAmount.Text), float.Parse(this.txtdPrice.Text), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLInvoice_Detail blDe = new BLInvoice_Detail();
                blDe.UpdateInvoice_Detail(this.txtIDI.Text, this.txtIDP.Text, int.Parse(this.txtdAmount.Text), float.Parse(this.txtdPrice.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvDETAIL.CurrentCell.RowIndex;
                string strDE1 = dgvDETAIL.Rows[r].Cells[0].Value.ToString();
                string strDE2 = dgvDETAIL.Rows[r].Cells[1].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbTY.DeleteInvoice_Detail(ref err, strDE1, strDE2);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtIDI.ResetText();
            this.txtIDP.ResetText();
            this.txtdAmount.ResetText();
            this.txtdPrice.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvDETAIL_CellContentClick(null, null);
        }

        private void UserControlInvoice_Detail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
