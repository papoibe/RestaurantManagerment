using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmKhuyenMai: Form
    {
        KhuyenMai_BL kmBL = new KhuyenMai_BL();
        string selectedId = "";
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            List<KhuyenMai_DTO> list = kmBL.GetAllKhuyenMai();

            dgvKhuyenMai.DataSource = list;

            dgvKhuyenMai.Columns["MaKhuyenMai"].HeaderText = "Mã KM";
            dgvKhuyenMai.Columns["TenKhuyenMai"].HeaderText = "Tên khuyến mãi";
            dgvKhuyenMai.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvKhuyenMai.Columns["PhanTramGiam"].HeaderText = "Giảm (%)";
            dgvKhuyenMai.Columns["NgayBatDau"].HeaderText = "Bắt đầu";
            dgvKhuyenMai.Columns["NgayKetThuc"].HeaderText = "Kết thúc";
            //dgvKhuyenMai.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvKhuyenMai.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvKhuyenMai.Columns["TrangThaiHienThi"].HeaderText = "Trạng thái";

            // Ẩn cột gốc kiểu bool để tránh lỗi FormatException
            dgvKhuyenMai.Columns["TrangThai"].Visible = false;

            dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {    // Validate inputs
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtContent.Text) ||
                string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            float discount;
            if (!float.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Phần trăm giảm phải là số hợp lệ!");
                return;
            }
            //create new
            KhuyenMai_DTO km = new KhuyenMai_DTO()
            {
                //MaKhuyenMai = Guid.NewGuid().ToString(), vì mã km trong db để indentity
                TenKhuyenMai = txtName.Text,
                NoiDung = txtContent.Text,
                PhanTramGiam = float.Parse(txtDiscount.Text),
                NgayBatDau = dtpStart.Value,
                NgayKetThuc = dtpFinish.Value,
                TrangThai =true,
                GhiChu = txtNote.Text
            };

            if (kmBL.AddKhuyenMai(km))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Không thể thêm");
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //check appropriate input
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần cập nhật!");
                return;
            }

            // Validate inputs
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            float discount;
            if (!float.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Phần trăm giảm phải là số hợp lệ!");
                return;
            }
            //make new discount 
            KhuyenMai_DTO km = new KhuyenMai_DTO()
            {
                MaKhuyenMai = int.Parse(selectedId), // lưu giữ mã KM đã chọn
                TenKhuyenMai = txtName.Text,
                NoiDung = txtContent.Text,
                PhanTramGiam = float.Parse(txtDiscount.Text),
                NgayBatDau = dtpStart.Value,
                NgayKetThuc = dtpFinish.Value,
                TrangThai = true,
                GhiChu = txtNote.Text
            };

            if (kmBL.UpdateKhuyenMai(km))
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Không thể cập nhật");
            LoadData() ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kmBL.DeleteKhuyenMai(selectedId))
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Xóa thất bại");
            LoadData() ;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            txtName.Clear();
            txtNote.Clear();
            txtDiscount.Clear();
            txtName.Focus();
        }

        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];

                selectedId = row.Cells["MaKhuyenMai"].Value.ToString();
                txtName.Text = row.Cells["TenKhuyenMai"].Value.ToString();
                txtContent.Text = row.Cells["NoiDung"].Value.ToString();
                txtDiscount.Text = row.Cells["PhanTramGiam"].Value.ToString();
                txtNote.Text = row.Cells["GhiChu"].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpFinish.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khuyến mãi nào chưa
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần kết thúc!");
                return;
            }

            // Xác nhận kết thúc khuyến mãi
            DialogResult result = MessageBox.Show("Bạn có chắc muốn kết thúc khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // Tạo DTO để cập nhật
            KhuyenMai_DTO km = new KhuyenMai_DTO()
            {
                MaKhuyenMai = int.Parse(selectedId),
                TrangThai = false // trạng thái khuyến mãi đã kết thúc
            };

            // Gọi phương thức cập nhật trạng thái
            if (kmBL.CompleteKhuyenMai(km))
            {
                MessageBox.Show("Khuyến mãi đã kết thúc!", "Thông báo");
                LoadData(); // Cập nhật lại giao diện
            }
            else
            {
                MessageBox.Show("Không thể cập nhật trạng thái.", "Lỗi");
            }
            LoadData();
        }
    }
}
