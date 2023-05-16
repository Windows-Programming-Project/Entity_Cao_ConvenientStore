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

namespace Convenience_Store_Entyti.DanhMuc
{
    public partial class FrmStock : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLStock dbSTO = new BLStock();
        public FrmStock()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvSTOCK.DataSource = dbSTO.TakeStock();
                // Thay đổi độ rộng cột
                dgvSTOCK.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtbatchID.ResetText();
                this.txtimDate.ResetText();
                this.txtamountofProduct.ResetText();
                this.txtsID.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvSTOCK_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table STOCK. Lỗi rồi!!!");
            }
        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtbatchID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtbatchID.ResetText();
            this.txtimDate.ResetText();
            this.txtamountofProduct.ResetText();
            this.txtsID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbatchID
            this.txtbatchID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvSTOCK_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbatchID
            this.txtbatchID.Enabled = false;
            this.txtimDate.Focus();

        }
        private void dgvSTOCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvSTOCK.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtbatchID.Text =
            dgvSTOCK.Rows[r].Cells[0].Value.ToString();
            this.txtimDate.Text =
            dgvSTOCK.Rows[r].Cells[1].Value.ToString();
            this.txtamountofProduct.Text =
            dgvSTOCK.Rows[r].Cells[2].Value.ToString();
            this.txtsID.Text =
            dgvSTOCK.Rows[r].Cells[3].Value.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtbatchID.ResetText();
            this.txtimDate.ResetText();
            this.txtamountofProduct.ResetText();
            this.txtsID.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvSTOCK_CellClick(null, null);
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
                    BLStock BLSto = new BLStock();
                    BLSto.AddStock(this.txtbatchID.Text, Convert.ToDateTime(this.txtimDate.Text), Convert.ToInt32(this.txtamountofProduct.Text), this.txtsID.Text, ref err);
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
                BLStock BLSto = new BLStock();
                BLSto.UpdateStock(this.txtbatchID.Text, Convert.ToDateTime(this.txtimDate.Text), Convert.ToInt32(this.txtamountofProduct.Text), this.txtsID.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvSTOCK.CurrentCell.RowIndex;
                string strSTO =
                dgvSTOCK.Rows[r].Cells[0].Value.ToString();
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
                    dbSTO.DeleteStock(ref err, strSTO);
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
    }
}
