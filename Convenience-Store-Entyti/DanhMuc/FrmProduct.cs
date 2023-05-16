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
    public partial class FrmProduct : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLProduct dbTY = new BLProduct();
        public FrmProduct()
        {
            InitializeComponent();
        }       
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvPRODUCT.DataSource = dbTY.TakeProduct();
                // Thay đổi độ rộng cột
                dgvPRODUCT.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtIDP.ResetText();
                this.txtpName.ResetText();
                this.txtpPrice.ResetText();
                this.txtIDT.ResetText();
                this.txtIDB.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvPRODUCT_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table PRODUCT. Lỗi rồi!!!");
            }
        }
        private void dgvPRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvPRODUCT.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtIDP.Text = dgvPRODUCT.Rows[r].Cells[0].Value.ToString();
            this.txtpName.Text = dgvPRODUCT.Rows[r].Cells[1].Value.ToString();
            this.txtpPrice.Text = dgvPRODUCT.Rows[r].Cells[2].Value.ToString();
            this.txtIDT.Text = dgvPRODUCT.Rows[r].Cells[3].Value.ToString();
            this.txtIDB.Text = dgvPRODUCT.Rows[r].Cells[4].Value.ToString();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtIDP.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtIDP.ResetText();
            this.txtpName.ResetText();
            this.txtpPrice.ResetText();
            this.txtIDT.ResetText();
            this.txtIDB.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txttID
            this.txtIDP.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvPRODUCT_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txttID
            this.txtIDP.Enabled = false;
            this.txtIDB.Focus();
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
                    BLProduct blPr = new BLProduct();
                    blPr.AddProduct(this.txtIDP.Text, this.txtpName.Text, float.Parse(this.txtpPrice.Text), this.txtIDT.Text, this.txtIDB.Text, ref err);
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
                BLProduct blPr = new BLProduct();
                blPr.UpdateProduct(this.txtIDP.Text, this.txtpName.Text, float.Parse(this.txtpPrice.Text), this.txtIDT.Text, this.txtIDB.Text, ref err);
                // Load lại dữ liệu trên DataGridView
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
            this.txtIDP.ResetText();
            this.txtpName.ResetText();
            this.txtpPrice.ResetText();
            this.txtIDT.ResetText();
            this.txtIDB.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvPRODUCT_CellClick(null, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvPRODUCT.CurrentCell.RowIndex;
                string strPRO1 = dgvPRODUCT.Rows[r].Cells[0].Value.ToString();
                string strPRO2 = dgvPRODUCT.Rows[r].Cells[3].Value.ToString();
                string strPRO3 = dgvPRODUCT.Rows[r].Cells[4].Value.ToString();
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
                    dbTY.DeleteProduct(ref err, strPRO1, strPRO2, strPRO3);
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
