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
    public partial class UserControlInvoice : UserControl
    {
        public UserControlInvoice()
        {
            InitializeComponent();
        }
        bool Them;
        string err;
        BLInvoice dbTY = new BLInvoice();
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời");


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtIDI.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtIDI.ResetText();
            this.txtIDE.ResetText();
            this.txtIDC.ResetText();
            this.txtiDate.ResetText();
            this.txtiTotal.ResetText();
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
            dgvINVOICE_CellContentClick(null, null);
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
            this.txtiTotal.Focus();
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
                    BLInvoice blIn = new BLInvoice();
                    
                    blIn.AddInvoice(this.txtIDI.Text, this.txtIDE.Text, this.txtIDC.Text, DateTime.Parse(this.txtiDate.Text), float.Parse(this.txtiTotal.Text),0, ref err);
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
                BLInvoice blIn = new BLInvoice();
                // blIn.UpdateInvoice(this.txtIDI.Text, this.txtIDE.Text, this.txtIDC.Text, DateTime.Parse(this.txtiDate.Text), float.Parse(this.txtiTotal.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            // Xóa trống các đối tượng trong Panel
            this.txtIDI.ResetText();
            this.txtIDE.ResetText();
            this.txtIDC.ResetText();
            this.txtiDate.ResetText();
            this.txtiTotal.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvINVOICE_CellContentClick(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvINVOICE.CurrentCell.RowIndex;
                string strINV1 = dgvINVOICE.Rows[r].Cells[0].Value.ToString();
                string strINV2 = dgvINVOICE.Rows[r].Cells[1].Value.ToString();
                string strINV3 = dgvINVOICE.Rows[r].Cells[2].Value.ToString();
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
                    dbTY.DeleteInvoice(ref err, strINV1, strINV2, strINV3);
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

        private void dgvINVOICE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvINVOICE.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtIDI.Text = dgvINVOICE.Rows[r].Cells[0].Value.ToString();
            this.txtIDE.Text = dgvINVOICE.Rows[r].Cells[1].Value.ToString();
            this.txtIDC.Text = dgvINVOICE.Rows[r].Cells[2].Value.ToString();
            this.txtiDate.Text = dgvINVOICE.Rows[r].Cells[3].Value.ToString();
            this.txtiTotal.Text = dgvINVOICE.Rows[r].Cells[4].Value.ToString();
            this.txtFinalTotalPay.Text = dgvINVOICE.Rows[r].Cells[5].Value.ToString();

        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvINVOICE.DataSource = dbTY.TakeInvoice();
                // Thay đổi độ rộng cột
                dgvINVOICE.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtIDI.ResetText();
                this.txtIDE.ResetText();
                this.txtIDC.ResetText();
                this.txtiDate.ResetText();
                this.txtiTotal.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvINVOICE_CellContentClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table INVOICE. Lỗi rồi!!!");
            }
        }
    }
}
