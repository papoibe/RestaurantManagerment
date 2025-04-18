using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private NhanVien_BL nhanVienBL = new NhanVien_BL();
        private int selectedMaNV = -1;
        private int selectedMaTK = -1;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            Load += FrmQuanLyNhanVien_Load; // Gọi sự kiện khi form load
            dgv1.CellClick += dgv1_CellClick;
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienToGrid();
        }
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv1.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];

                txtTaiKhoan.Text = row.Cells["Username"].Value?.ToString();
                txtMatKhau.Text = row.Cells["Password"].Value?.ToString();
                txtTenHienThi.Text = row.Cells["DisplayName"].Value?.ToString();

                txtTen.Text = row.Cells["HoTen"].Value?.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                DTPBirth.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                DTPIn.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);

                // Lưu lại MaNhanVien và MaTaiKhoan để sử dụng khi cập nhật
                selectedMaNV = Convert.ToInt32(row.Cells["MaNhanVien"].Value);
                selectedMaTK = Convert.ToInt32(row.Cells["MaTaiKhoan"].Value);
            }
        }
        private void ClearInputs()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTenHienThi.Text = "";
            txtTen.Text = "";
            cbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            DTPBirth.Value = DateTime.Now;
            DTPIn.Value = DateTime.Now;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dgv1.ClearSelection();
        }
        private void LoadNhanVienToGrid()
        {
            try
            {
                var danhSachNV = nhanVienBL.LayDanhSachNhanVien();
                dgv1.DataSource = danhSachNV;

                // Tuỳ chọn: đổi tên cột
                dgv1.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgv1.Columns["HoTen"].HeaderText = "Họ tên";
                dgv1.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv1.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgv1.Columns["SDT"].HeaderText = "SĐT";
                dgv1.Columns["Email"].HeaderText = "Email";
                dgv1.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
                dgv1.Columns["TrangThai"].Visible = false; // Ẩn nếu không cần
                dgv1.Columns["MaTaiKhoan"].Visible = false;

                dgv1.Columns["Username"].HeaderText = "TenDangNhap";
                dgv1.Columns["Password"].HeaderText = "MatKhau";
                dgv1.Columns["DisplayName"].HeaderText = "TenHienThi";
                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    Username = txtTaiKhoan.Text,
                    Password = txtMatKhau.Text,
                    DisplayName = txtTenHienThi.Text,
                    HoTen = txtTen.Text,
                    GioiTinh = cbGioiTinh.Text,
                    NgaySinh = DTPBirth.Value,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    NgayVaoLam = DTPIn.Value,
                    TrangThai = true
                };

                if (nhanVienBL.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVienToGrid();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == -1 || selectedMaTK == -1)
            {
                MessageBox.Show("Hãy chọn một nhân viên để cập nhật.");
                return;
            }

            var nv = new NhanVien_DTO
            {
                MaNhanVien = selectedMaNV,
                MaTaiKhoan = selectedMaTK,
                Username = txtTaiKhoan.Text,
                Password = txtMatKhau.Text,
                DisplayName = txtTenHienThi.Text,
                HoTen = txtTen.Text,
                GioiTinh = cbGioiTinh.Text,
                NgaySinh = DTPBirth.Value,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                NgayVaoLam = DTPIn.Value,
                TrangThai = true
            };

            if (nhanVienBL.CapNhatNhanVien(nv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadNhanVienToGrid();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv1.CurrentRow != null)
            {
                int maNV = Convert.ToInt32(dgv1.CurrentRow.Cells["MaNhanVien"].Value);
                int maTK = Convert.ToInt32(dgv1.CurrentRow.Cells["MaTaiKhoan"].Value);

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (nhanVienBL.XoaNhanVien(maNV, maTK))
                    {
                        MessageBox.Show("Đã xóa thành công.");
                        LoadNhanVienToGrid();
                        ClearInputs();
                    }
                    else
                        MessageBox.Show("Xóa thất bại.");
                }
            }
        }
    }

}
