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
using System.IO;
using System.Data.SqlClient;
namespace PresentationLayer
{
    public partial class FrmKiemSoatChatLuong : Form
    {
        private KiemTraChatLuong_BL kiemTraBL;
        private string maKiemTraCurrent = "";
        private List<string> loaiKiemTraList = new List<string> { "NguyenLieu", "MonAn", "ThietBi" };
        private List<string> ketQuaList = new List<string> { "Đạt", "Không đạt", "Cần kiểm tra lại" };
        private string selectedImagePath = "";
        private bool isNewRecord = true;
        public FrmKiemSoatChatLuong()
        {
            InitializeComponent();
            kiemTraBL = new KiemTraChatLuong_BL();
        }

        private void FrmKiemSoatChatLuong_Load(object sender, EventArgs e)
        {
            // Thiết lập người dùng hiện tại
            lblCurrentUser.Text = "Người dùng: Nhân viên";

            // Khởi tạo combobox
            LoadComboBoxes();

            // Khởi tạo danh sách kiểm tra
            LoadDanhSachKiemTra();

            // Đặt ngày kiểm tra mặc định là ngày hiện tại
            dtpNgayKiemTra.Value = DateTime.Now;
            timeNgayKiemTra.Value = DateTime.Now;

            // Thiết lập filter date
            dtpFilterFrom.Value = DateTime.Now.AddDays(-30);
            dtpFilterTo.Value = DateTime.Now;

            // Xóa dữ liệu trong form
            ResetForm();

            // Vô hiệu hóa control chi tiết ban đầu
            EnableEditControls(false);

            // Tải thống kê
            LoadThongKe();
        }

        // Tải dữ liệu thống kê
        private void LoadThongKe()
        {
            try
            {
                // Đếm số lượng kiểm tra theo kết quả
                int soDat = 0;
                int soKhongDat = 0;
                int soCanKiemTraLai = 0;

                // Đếm số lượng cảnh báo
                int soNguyenLieuCanhBao = 0;
                int soMonAnCanhBao = 0;
                int soThietBiCanhBao = 0;

                // Lấy danh sách kiểm tra
                List<KiemTraChatLuong_DTO> danhSachKiemTra = kiemTraBL.GetKiemTraChatLuongList();

                foreach (var item in danhSachKiemTra)
                {
                    // Đếm theo kết quả
                    if (item.KetQua == "Đạt")
                        soDat++;
                    else if (item.KetQua == "Không đạt")
                    {
                        soKhongDat++;

                        // Đếm theo loại
                        if (item.LoaiKiemTra == "NguyenLieu")
                            soNguyenLieuCanhBao++;
                        else if (item.LoaiKiemTra == "MonAn")
                            soMonAnCanhBao++;
                        else if (item.LoaiKiemTra == "ThietBi")
                            soThietBiCanhBao++;
                    }
                    else if (item.KetQua == "Cần kiểm tra lại")
                        soCanKiemTraLai++;
                }

                // Hiển thị số liệu
                lblSoDat.Text = soDat.ToString();
                lblSoKhongDat.Text = soKhongDat.ToString();
                lblSoCanKiemTra.Text = soCanKiemTraLai.ToString();

                lblSoNguyenLieuCanhBao.Text = soNguyenLieuCanhBao.ToString();
                lblSoMonAnCanhBao.Text = soMonAnCanhBao.ToString();
                lblSoThietBiCanhBao.Text = soThietBiCanhBao.ToString();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Lỗi: " + ex.Message;
            }
        }

        // Tải dữ liệu vào combobox
        private void LoadComboBoxes()
        {
            // Loại kiểm tra
            cboLoaiKiemTra.DataSource = null;
            cboLoaiKiemTra.DataSource = loaiKiemTraList;

            // Kết quả
            cboKetQua.DataSource = null;
            cboKetQua.DataSource = ketQuaList;

            // Filter loại
            cboFilterLoai.SelectedIndex = 0;

            // Filter kết quả
            cboFilterKetQua.SelectedIndex = 0;
        }

        // Tải danh sách kiểm tra
        private void LoadDanhSachKiemTra()
        {
            try
            {
                lblStatus.Text = "Đang tải dữ liệu...";
                progressBar.Visible = true;

                // Lấy danh sách kiểm tra từ Business Layer
                List<KiemTraChatLuong_DTO> dsKiemTra = kiemTraBL.GetKiemTraChatLuongList();

                // Gán DataSource cho DataGridView
                dgvKiemTra.DataSource = null;
                dgvKiemTra.DataSource = dsKiemTra;

                // Định dạng các cột sau khi đã gán DataSource
                if (dgvKiemTra.Columns.Contains("MaKiemTra"))
                {
                    dgvKiemTra.Columns["MaKiemTra"].HeaderText = "Mã KT";
                    dgvKiemTra.Columns["MaKiemTra"].Width = 80;
                }

                if (dgvKiemTra.Columns.Contains("LoaiKiemTra"))
                {
                    dgvKiemTra.Columns["LoaiKiemTra"].HeaderText = "Loại KT";
                    dgvKiemTra.Columns["LoaiKiemTra"].Width = 100;
                }

                if (dgvKiemTra.Columns.Contains("DoiTuongKiemTra"))
                {
                    dgvKiemTra.Columns["DoiTuongKiemTra"].HeaderText = "Đối tượng";
                    dgvKiemTra.Columns["DoiTuongKiemTra"].Width = 120;
                }

                if (dgvKiemTra.Columns.Contains("NgayKiemTra"))
                {
                    dgvKiemTra.Columns["NgayKiemTra"].HeaderText = "Ngày KT";
                    dgvKiemTra.Columns["NgayKiemTra"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvKiemTra.Columns["NgayKiemTra"].Width = 150;
                }

                if (dgvKiemTra.Columns.Contains("NguoiKiemTra"))
                    dgvKiemTra.Columns["NguoiKiemTra"].Visible = false;

                if (dgvKiemTra.Columns.Contains("TenNguoiKiemTra"))
                {
                    dgvKiemTra.Columns["TenNguoiKiemTra"].HeaderText = "Người KT";
                    dgvKiemTra.Columns["TenNguoiKiemTra"].Width = 150;
                }

                if (dgvKiemTra.Columns.Contains("TieuChiKiemTra"))
                {
                    dgvKiemTra.Columns["TieuChiKiemTra"].HeaderText = "Tiêu chí";
                    dgvKiemTra.Columns["TieuChiKiemTra"].Width = 150;
                }

                if (dgvKiemTra.Columns.Contains("GiaTri"))
                {
                    dgvKiemTra.Columns["GiaTri"].HeaderText = "Giá trị";
                    dgvKiemTra.Columns["GiaTri"].Width = 80;
                }

                if (dgvKiemTra.Columns.Contains("DonVi"))
                {
                    dgvKiemTra.Columns["DonVi"].HeaderText = "Đơn vị";
                    dgvKiemTra.Columns["DonVi"].Width = 80;
                }

                if (dgvKiemTra.Columns.Contains("KetQua"))
                {
                    dgvKiemTra.Columns["KetQua"].HeaderText = "Kết quả";
                    dgvKiemTra.Columns["KetQua"].Width = 100;

                    // Định dạng màu dựa trên kết quả
                    dgvKiemTra.Columns["KetQua"].DefaultCellStyle.Format = "N2";
                    dgvKiemTra.CellFormatting += dgvKiemTra_CellFormatting;
                }

                if (dgvKiemTra.Columns.Contains("GhiChu"))
                {
                    dgvKiemTra.Columns["GhiChu"].HeaderText = "Ghi chú";
                    dgvKiemTra.Columns["GhiChu"].Width = 200;
                }

                if (dgvKiemTra.Columns.Contains("HinhAnh"))
                    dgvKiemTra.Columns["HinhAnh"].Visible = false;

                // Thiết lập định dạng chung cho DataGridView
                dgvKiemTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKiemTra.AllowUserToAddRows = false;
                dgvKiemTra.AllowUserToDeleteRows = false;
                dgvKiemTra.ReadOnly = true;
                dgvKiemTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                progressBar.Visible = false;
                lblStatus.Text = "Đã tải " + dsKiemTra.Count + " bản ghi";
            }
            catch (SqlException ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi SQL: " + ex.Message;
                MessageBox.Show("Lỗi khi tải danh sách kiểm tra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi: " + ex.Message;
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // dinh dang mau cho KetQua
        private void dgvKiemTra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvKiemTra.Columns[e.ColumnIndex].Name == "KetQua" && e.Value != null)
            {
                string ketQua = e.Value.ToString();
                if (ketQua == "Đạt")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(dgvKiemTra.Font, FontStyle.Bold);
                }
                else if (ketQua == "Không đạt")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dgvKiemTra.Font, FontStyle.Bold);
                }
                else if (ketQua == "Cần kiểm tra lại")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    e.CellStyle.Font = new Font(dgvKiemTra.Font, FontStyle.Bold);
                }
            }
        }

        private void EnableEditControls(bool enable)
        {
            // Điều khiển trạng thái các controls
            cboLoaiKiemTra.Enabled = enable;
            txtDoiTuong.Enabled = enable;
            btnChonDoiTuong.Enabled = enable;
            txtMaNhanVien.Enabled = true; // Luôn cho phép nhập mã nhân viên
            txtTieuChi.Enabled = enable;
            txtGiaTri.Enabled = enable;
            txtDonVi.Enabled = enable;
            cboKetQua.Enabled = enable;
            txtGhiChu.Enabled = enable;
            btnChonAnh.Enabled = enable;

            btnThem.Enabled = enable;
            btnXoa.Enabled = enable;
            btnCapNhat.Enabled = enable;
            btnLamMoi.Enabled = enable;
        }


        private void ResetForm()
        {
            // Reset thông tin nhập
            txtMaKiemTra.Text = "";
            txtMaNhanVien.Text = "";
            txtDoiTuong.Text = "";
            txtTieuChi.Text = "";
            txtGiaTri.Text = "0";
            txtDonVi.Text = "";
            txtGhiChu.Text = "";
            dtpNgayKiemTra.Value = DateTime.Now;
            timeNgayKiemTra.Value = DateTime.Now;

            // Reset ảnh
            picAnhMinhHoa.Image = null;
            selectedImagePath = "";

            // Reset mã kiểm tra hiện tại
            maKiemTraCurrent = "";
            isNewRecord = true;
        }

        //kiem tra nhan vien ton tai
        private bool KiemTraNhanVienTonTai(int maNhanVien)
        {
            try
            {
                return kiemTraBL.KiemTraNhanVienTonTai(maNhanVien);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Lỗi: " + ex.Message;
                MessageBox.Show("Lỗi kiểm tra nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnThemKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy và kiểm tra mã nhân viên từ textbox
                int maNhanVien;
                if (!int.TryParse(txtMaNhanVien.Text.Trim(), out maNhanVien) || maNhanVien <= 0)
                {
                    MessageBox.Show("Mã nhân viên phải là số nguyên dương.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Kiểm tra mã nhân viên có tồn tại trong CSDL không
                if (!KiemTraNhanVienTonTai(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Tạo đối tượng kiểm tra mới
                KiemTraChatLuong_DTO kiemTra = new KiemTraChatLuong_DTO();
                kiemTra.MaKiemTra = ""; // Sẽ được tạo tự động trong BL
                kiemTra.LoaiKiemTra = cboLoaiKiemTra.SelectedItem.ToString();
                kiemTra.DoiTuongKiemTra = txtDoiTuong.Text.Trim();

                // Kết hợp ngày và giờ
                DateTime ngayGio = dtpNgayKiemTra.Value.Date.Add(timeNgayKiemTra.Value.TimeOfDay);
                kiemTra.NgayKiemTra = ngayGio;

                kiemTra.NguoiKiemTra = maNhanVien;
                kiemTra.TieuChiKiemTra = txtTieuChi.Text.Trim();

                // Xử lý giá trị
                float giaTri;
                if (float.TryParse(txtGiaTri.Text.Trim(), out giaTri))
                    kiemTra.GiaTri = giaTri;
                else
                    kiemTra.GiaTri = null;

                kiemTra.DonVi = txtDonVi.Text.Trim();
                kiemTra.KetQua = cboKetQua.SelectedItem.ToString();
                kiemTra.GhiChu = txtGhiChu.Text.Trim();

                // Xử lý ảnh nếu có
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    // Lưu ảnh hoặc tên file
                    kiemTra.HinhAnh = Path.GetFileName(selectedImagePath);
                }
                else
                {
                    kiemTra.HinhAnh = null;
                }

                lblStatus.Text = "Đang tạo phiếu kiểm tra...";
                progressBar.Visible = true;

                // Thêm phiếu kiểm tra và lấy kết quả
                bool result = kiemTraBL.AddKiemTraChatLuong(kiemTra);
                if (result)
                {
                    MessageBox.Show("Tạo phiếu kiểm tra thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Enable các control
                    EnableEditControls(true);

                    // Load lại danh sách kiểm tra
                    LoadDanhSachKiemTra();

                    // Hiển thị thông tin phiếu vừa tạo
                    KiemTraChatLuong_DTO kiemTraMoi = kiemTraBL.GetKiemTraById(kiemTra.MaKiemTra);
                    if (kiemTraMoi != null)
                    {
                        maKiemTraCurrent = kiemTraMoi.MaKiemTra;
                        txtMaKiemTra.Text = kiemTraMoi.MaKiemTra;
                        SelectRowByMaKiemTra(kiemTraMoi.MaKiemTra);
                    }

                    // Cập nhật trạng thái
                    lblStatus.Text = "Đã tạo phiếu kiểm tra thành công";

                    // Cập nhật thống kê
                    LoadThongKe();

                    // Đánh dấu là không phải bản ghi mới nữa
                    isNewRecord = false;
                }
                else
                {
                    MessageBox.Show("Không thể tạo phiếu kiểm tra. Vui lòng thử lại.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Lỗi: Không thể tạo phiếu kiểm tra";
                }

                progressBar.Visible = false;
            }
            catch (SqlException ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi SQL: " + ex.Message;
                MessageBox.Show("Lỗi SQL khi tạo phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi: " + ex.Message;
                MessageBox.Show("Lỗi khi tạo phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Phương thức chọn dòng trong DataGridView theo mã kiểm tra
        private void SelectRowByMaKiemTra(string maKiemTra)
        {
            try
            {
                foreach (DataGridViewRow row in dgvKiemTra.Rows)
                {
                    if (row.Cells["MaKiemTra"].Value.ToString() == maKiemTra)
                    {
                        dgvKiemTra.CurrentCell = row.Cells[0];
                        dgvKiemTra.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi chọn dòng: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã kiểm tra hiện tại
                if (string.IsNullOrEmpty(maKiemTraCurrent))
                {
                    MessageBox.Show("Vui lòng tạo phiếu kiểm tra trước khi thêm chi tiết.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(txtDoiTuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đối tượng kiểm tra.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDoiTuong.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cboKetQua.Text))
                {
                    MessageBox.Show("Vui lòng chọn kết quả kiểm tra.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboKetQua.Focus();
                    return;
                }

                // Kiểm tra mã nhân viên
                int maNhanVien;
                if (!int.TryParse(txtMaNhanVien.Text.Trim(), out maNhanVien) || maNhanVien <= 0)
                {
                    MessageBox.Show("Mã nhân viên phải là số nguyên dương.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Kiểm tra nhân viên tồn tại
                if (!KiemTraNhanVienTonTai(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Tạo đối tượng kiểm tra
                KiemTraChatLuong_DTO kiemTra = new KiemTraChatLuong_DTO();
                kiemTra.MaKiemTra = maKiemTraCurrent;
                kiemTra.LoaiKiemTra = cboLoaiKiemTra.SelectedItem.ToString();
                kiemTra.DoiTuongKiemTra = txtDoiTuong.Text.Trim();
                kiemTra.NgayKiemTra = dtpNgayKiemTra.Value;
                kiemTra.NguoiKiemTra = maNhanVien;
                kiemTra.TieuChiKiemTra = txtTieuChi.Text.Trim();

                // Xử lý giá trị
                float giaTri;
                if (float.TryParse(txtGiaTri.Text.Trim(), out giaTri))
                    kiemTra.GiaTri = giaTri;
                else
                    kiemTra.GiaTri = null;

                kiemTra.DonVi = txtDonVi.Text.Trim();
                kiemTra.KetQua = cboKetQua.SelectedItem.ToString();
                kiemTra.GhiChu = txtGhiChu.Text.Trim();
                kiemTra.HinhAnh = null; // Xử lý hình ảnh nếu cần

                // Cập nhật phiếu kiểm tra
                bool result = kiemTraBL.UpdateKiemTraChatLuong(kiemTra);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin kiểm tra thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại danh sách kiểm tra
                    LoadDanhSachKiemTra();

                    // Chọn lại phiếu kiểm tra vừa cập nhật
                    SelectRowByMaKiemTra(maKiemTraCurrent);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin kiểm tra.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi cập nhật thông tin kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã kiểm tra hiện tại
                if (string.IsNullOrEmpty(maKiemTraCurrent))
                {
                    MessageBox.Show("Vui lòng chọn phiếu kiểm tra cần xóa.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu kiểm tra này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa phiếu kiểm tra
                    bool success = kiemTraBL.DeleteKiemTraChatLuong(maKiemTraCurrent);
                    if (success)
                    {
                        MessageBox.Show("Xóa phiếu kiểm tra thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại danh sách kiểm tra
                        LoadDanhSachKiemTra();

                        // Reset form
                        ResetForm();

                        // Vô hiệu hóa các controls
                        EnableEditControls(false);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phiếu kiểm tra.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi xóa phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã kiểm tra hiện tại
                if (string.IsNullOrEmpty(maKiemTraCurrent))
                {
                    MessageBox.Show("Vui lòng chọn phiếu kiểm tra cần cập nhật.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã nhân viên
                int maNhanVien;
                if (!int.TryParse(txtMaNhanVien.Text.Trim(), out maNhanVien) || maNhanVien <= 0)
                {
                    MessageBox.Show("Mã nhân viên phải là số nguyên dương.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Kiểm tra nhân viên tồn tại
                if (!KiemTraNhanVienTonTai(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                // Tạo đối tượng kiểm tra
                KiemTraChatLuong_DTO kiemTra = new KiemTraChatLuong_DTO();
                kiemTra.MaKiemTra = maKiemTraCurrent;
                kiemTra.LoaiKiemTra = cboLoaiKiemTra.SelectedItem.ToString();
                kiemTra.DoiTuongKiemTra = txtDoiTuong.Text.Trim();
                kiemTra.NgayKiemTra = dtpNgayKiemTra.Value;
                kiemTra.NguoiKiemTra = maNhanVien;
                kiemTra.TieuChiKiemTra = txtTieuChi.Text.Trim();

                // Xử lý giá trị
                float giaTri;
                if (float.TryParse(txtGiaTri.Text.Trim(), out giaTri))
                    kiemTra.GiaTri = giaTri;
                else
                    kiemTra.GiaTri = null;

                kiemTra.DonVi = txtDonVi.Text.Trim();
                kiemTra.KetQua = cboKetQua.SelectedItem.ToString();
                kiemTra.GhiChu = txtGhiChu.Text.Trim();
                kiemTra.HinhAnh = null; // Xử lý hình ảnh nếu cần

                // Cập nhật phiếu kiểm tra
                bool result = kiemTraBL.UpdateKiemTraChatLuong(kiemTra);
                if (result)
                {
                    MessageBox.Show("Cập nhật phiếu kiểm tra thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại danh sách kiểm tra
                    LoadDanhSachKiemTra();

                    // Chọn lại phiếu kiểm tra vừa cập nhật
                    SelectRowByMaKiemTra(maKiemTraCurrent);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật phiếu kiểm tra.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi cập nhật phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Reset form
            ResetForm();
            EnableEditControls(false);
        }

        private void dgvKiemTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy thông tin phiếu kiểm tra được chọn
                    DataGridViewRow row = dgvKiemTra.Rows[e.RowIndex];
                    maKiemTraCurrent = row.Cells["MaKiemTra"].Value.ToString();

                    // Hiển thị thông tin phiếu kiểm tra
                    txtMaKiemTra.Text = maKiemTraCurrent;
                    txtMaNhanVien.Text = row.Cells["NguoiKiemTra"].Value.ToString();

                    // Đảm bảo chọn đúng loại kiểm tra
                    string loaiKiemTra = row.Cells["LoaiKiemTra"].Value.ToString();
                    for (int i = 0; i < cboLoaiKiemTra.Items.Count; i++)
                    {
                        if (cboLoaiKiemTra.Items[i].ToString() == loaiKiemTra)
                        {
                            cboLoaiKiemTra.SelectedIndex = i;
                            break;
                        }
                    }

                    txtDoiTuong.Text = row.Cells["DoiTuongKiemTra"].Value.ToString();
                    dtpNgayKiemTra.Value = Convert.ToDateTime(row.Cells["NgayKiemTra"].Value);

                    // Xử lý các giá trị có thể null
                    txtTieuChi.Text = row.Cells["TieuChiKiemTra"].Value != null && row.Cells["TieuChiKiemTra"].Value != DBNull.Value
                        ? row.Cells["TieuChiKiemTra"].Value.ToString() : "";

                    txtGiaTri.Text = row.Cells["GiaTri"].Value != null && row.Cells["GiaTri"].Value != DBNull.Value
                        ? row.Cells["GiaTri"].Value.ToString() : "0";

                    txtDonVi.Text = row.Cells["DonVi"].Value != null && row.Cells["DonVi"].Value != DBNull.Value
                        ? row.Cells["DonVi"].Value.ToString() : "";

                    // Đảm bảo chọn đúng kết quả
                    string ketQua = row.Cells["KetQua"].Value.ToString();
                    for (int i = 0; i < cboKetQua.Items.Count; i++)
                    {
                        if (cboKetQua.Items[i].ToString() == ketQua)
                        {
                            cboKetQua.SelectedIndex = i;
                            break;
                        }
                    }

                    txtGhiChu.Text = row.Cells["GhiChu"].Value != null && row.Cells["GhiChu"].Value != DBNull.Value
                        ? row.Cells["GhiChu"].Value.ToString() : "";

                    // Enable các control
                    EnableEditControls(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn phiếu kiểm tra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dgvKiemTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gọi phương thức CellClick để xử lý thống nhất
            dgvKiemTra_CellClick(sender, e);
        }

        private void btnChonDoiTuong_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh minh họa";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    picAnhMinhHoa.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Đang lọc dữ liệu...";
                progressBar.Visible = true;

                // TODO: Implement logic lọc dữ liệu

                progressBar.Visible = false;
                lblStatus.Text = "Đã lọc dữ liệu thành công";
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi: " + ex.Message;
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    LoadDanhSachKiemTra();
                    return;
                }

                lblStatus.Text = "Đang tìm kiếm...";
                progressBar.Visible = true;

                // TODO: Implement logic tìm kiếm

                progressBar.Visible = false;
                lblStatus.Text = "Đã tìm kiếm thành công";
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Lỗi: " + ex.Message;
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
