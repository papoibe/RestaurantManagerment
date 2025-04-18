using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using Microsoft.VisualBasic;

namespace PresentationLayer
{

    public partial class FrmDonHang : Form
    {
        // khi frm này mở lên 
        // 1. load menu món theo loaị món
        // 2. load đơn hàng cũ theo mã bàn
        // 3. khi ấn chọn loại món sẽ hiện các món trong loại đó,
        //public Action OnOrderSaved;


        private int maDH, maBan; // mã đơn hàng để load những món cũ và thêm những món mới theo mã đơn hàng, maBan để tạo đơn hàng mới theo mã bàn
        private MonAn_BL monAnBL = new MonAn_BL(); // tạo để load menu lên
        private DonHang_BL donHangBL = new DonHang_BL();// tạo để sử dụng hàm Insert 
        private Ban_BL banBL = new Ban_BL(); // tạo để cập nhật trạng thái bàn
        private DonHang_DTO donHang = new DonHang_DTO(); // tạo để tao
        private ChiTietDonHang_BL chiTietDonHang_BL = new ChiTietDonHang_BL(); // dùng để thêm chitietdonhang_DTO vào CSDL
        private List<MonAn_DTO> dsMonAnTam = new List<MonAn_DTO>();
        private List<LoaiMonAn_DTO> loaiMonAn_DTOs = new List<LoaiMonAn_DTO>(); // tạo để load loại món ăn lên
        public FrmDonHang(int MaDH, int MaBan) // day la load đơn hàng cũ của bàn đó
        {
            InitializeComponent();
            maDH = MaDH;
            maBan = MaBan;
            lb_MaBan.Text = maBan.ToString();
            lb_MaDonHang.Text = maDH.ToString();

        }
        public FrmDonHang(DonHang_DTO donHangMoi, int MaBan) // đây là đơn hàng mới được tạo theo mã bàn
        {
            InitializeComponent();
            donHang = donHangMoi;
            maBan = MaBan;
            lb_MaBan.Text = maBan.ToString();
        }
        private void FrmDonHang_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadMonAnByMaDH();
            gBHinhThucTT.Visible = false; // ẩn groupbox hình thức thanh toán
            lb_sum.Text = donHangBL.GetTongTien(maDH).ToString(); // cập nhật tổng tiền trên giao diện
        }
        private void LoadMenu()
        {
            var loaiMonAn = monAnBL.GetAllLoaiMonAn(); // lấy danh sách loại món ăn từ cơ sở dữ liệu
            foreach (var loai in loaiMonAn)
            {
                Button btnLoaiMonAn = new Button
                {
                    Text = loai.TenLoai,
                    Size = new Size(150, 60),
                    BackColor = Color.LightGreen,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Tag = loai // Lưu thông tin loại món ăn trong thuộc tính Tag
                };
                btnLoaiMonAn.Click += BtnLoaiMonAn_Click;
                fLP_Menu.Controls.Add(btnLoaiMonAn);
            }
            //var danhSachMonAn = monAnBL.GetAll();
            //foreach (var monAn in danhSachMonAn)
            //{
            //    Button btnMonAn = new Button
            //    {
            //        Text = monAn.TenMonAn + "\n" + monAn.DonGia,
            //        Size = new Size(100, 100),
            //        BackColor = Color.LightBlue,
            //        ForeColor = Color.Black,
            //        Font = new Font("Arial", 12, FontStyle.Bold),
            //        Tag = monAn // Lưu thông tin món ăn trong thuộc tính Tag
            //    };
            //    btnMonAn.Click += BtnMonAn_Click;
            //    fLP_Menu.Controls.Add(btnMonAn);
            //}
        }
        private void BtnLoaiMonAn_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng click vào loại món ăn
            Button btnClicked = sender as Button;
            LoaiMonAn_DTO loaiMonAn = btnClicked.Tag as LoaiMonAn_DTO;
            if (loaiMonAn != null)
            {
                // Xóa các nút món ăn cũ
                fLP_Menu.Controls.Clear();
                // Tạo lại nút quay lại
                Button btnBack = new Button
                {
                    Text = "Quay lại",
                    Size = new Size(100, 50),
                    BackColor = Color.LightBlue,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };
                btnBack.Click += BtnBack_Click;
                
                fLP_Menu.Controls.Add(btnBack);
                // Lấy danh sách món ăn theo loại
                var danhSachMonAn = monAnBL.GetMonAnByLoai(loaiMonAn.MaLoai);
                foreach (var monAn in danhSachMonAn)
                {
                    Button btnMonAn = new Button
                    {
                        Text = monAn.TenMonAn + "\n" + monAn.DonGia.ToString("C"),
                        Size = new Size(150, 60),
                        BackColor = Color.LightBlue,
                        ForeColor = Color.Black,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Tag = monAn // Lưu thông tin món ăn trong thuộc tính Tag
                    };
                    btnMonAn.Click += BtnMonAn_Click;
                    fLP_Menu.Controls.Add(btnMonAn);
                }
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Xóa các nút món ăn cũ
            fLP_Menu.Controls.Clear();
            // Tạo lại nút quay lại
            LoadMenu();
        }
        private void LoadMonAnByMaDH()// do not torch
        {
            // Lấy danh sách món ăn từ cơ sở dữ liệu theo mã hóa đơn
            var danhSachMonAn = monAnBL.GetMonAnByMaDH(maDH);
            foreach (var monAn in danhSachMonAn)
            {
                ListViewItem item = new ListViewItem(monAn.TenMonAn);
                item.SubItems.Add(monAn.SoLuong.ToString());
                item.SubItems.Add(monAn.DonGia.ToString("C"));
                item.SubItems.Add((monAn.SoLuong * monAn.DonGia).ToString("C")); // Tính thành tiền
                lvDonHang.Items.Add(item);
            }
        }
        private void BtnMonAn_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng click vào món ăn
            Button btnClicked = sender as Button;
            MonAn_DTO monAn = btnClicked.Tag as MonAn_DTO;
            if (monAn != null)
            {
                // Tạo một ListViewItem mới với thông tin món ăn
                ListViewItem item = new ListViewItem(monAn.TenMonAn);
                item.SubItems.Add("1"); // Số lượng mặc định là 1
                item.SubItems.Add(monAn.DonGia.ToString("C")); // Đơn giá
                item.SubItems.Add(monAn.DonGia.ToString("C")); // Thành tiền (1 * Đơn giá)
                lvDonHang.Items.Add(item); // Thêm vào ListView
                dsMonAnTam.Add(monAn);
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e) // tạo mới đơn hàng bằng mã bàn và lưu các món ăn tạm vào csdl Chitietdonhang theo mã bàn
        {
            if (banBL.GetTrangThaiBan(maBan) == true) // bàn chưa có đơn hàng
                donHangBL.Insert(donHang); // Lưu đơn hàng vào cơ sở dữ liệu    

            maDH = donHangBL.GetLastId(maBan); // Lấy mã đơn hàng vừa được tạo
            foreach (var monAn in dsMonAnTam)
            {
                ChiTietDonHang_DTO chiTiet = new ChiTietDonHang_DTO
                {
                    MaDonHang = maDH,
                    MaMonAn = monAn.MaMonAn,
                    SoLuong = 1, // Số lượng mặc định là 1
                    DonGia = monAn.DonGia,
                    ThanhTien = monAn.DonGia, // Thành tiền (1 * Đơn giá)
                    GhiChu = string.Empty // Ghi chú mặc định là rỗng
                };
                chiTietDonHang_BL.Insert(chiTiet);
            }
            donHang = donHangBL.GetById(maDH); // Lấy lại đơn hàng vừa được tạo
            donHang.TongTien += dsMonAnTam.Sum(x => x.DonGia); // Tính tổng tiền từ danh sách món ăn + tiền đã có sẵn 
            dsMonAnTam.Clear(); // Xóa danh sách món ăn tạm sau khi đã lưu vào cơ sở dữ liệu
            donHangBL.Update(donHang); // Cập nhật đơn hàng

            lb_sum.Text = donHangBL.GetTongTien(maDH).ToString(); // Cập nhật tổng tiền trên giao diện

            banBL.CapNhatTrangThaiBan(maBan, false);
            //this.Close();
            //
            //OnOrderSaved?.Invoke(); // Gọi sự kiện khi đơn hàng được lưu

        } // không đụng đến

        private void HoanTatThanhToan()
        {
            banBL.CapNhatTrangThaiBan(maBan, true); // cập nhật trạng thái bàn về trống
            this.Close();
            //OnOrderSaved?.Invoke(); // gọi callback
        } // gọi để hoàn tất thanh toán

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (banBL.GetTrangThaiBan(maBan) == true) // bàn chua có đơn hàng
                btn_ThanhToan.Enabled = false; // không cho thanh toán
            else
            {
                HinhThucThanhToan();
                //banBL.CapNhatTrangThaiBan(maBan, true); // Cập nhật trạng thái bàn về trống
                //this.Close();
                //OnOrderSaved?.Invoke();
            }
        } // không đụng đến
        private void ShowQRCode(string phuongThuc)
        {
            Form qrForm = new Form
            {
                Text = "Mã QR " + phuongThuc,
                Size = new Size(300, 350),
                StartPosition = FormStartPosition.CenterParent
            };

            PictureBox qrPic = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Tạm thời hiển thị ảnh mặc định QR (bạn thay bằng ảnh thật nếu có)
            // qrPic.Image = Properties.Resources.qr_demo; // Add ảnh qr_demo vào Resources

            Button btnXacNhan = new Button
            {
                Text = "Xác nhận đã chuyển",
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.LightGreen
            };
            btnXacNhan.Click += (s, e) =>
            {
                qrForm.Close();
                MessageBox.Show("Xác nhận đã chuyển khoản thành công!", "Thành công");
                HoanTatThanhToan();
            };

            qrForm.Controls.Add(btnXacNhan);
            qrForm.Controls.Add(qrPic);
            qrForm.ShowDialog();
        }

        private void txt_SoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Không phát tiếng beep
                string input = txt_SoTien.Text;
                if (decimal.TryParse(input, out decimal soTien))
                {
                    lb_sum.Text = soTien.ToString("C");
                    HoanTatThanhToan();
                }
                else
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void HinhThucThanhToan()
        {
            fLP_Menu.Controls.Clear();
            Button btnBack = new Button
            {
                Text = "Quay lại",
                Size = new Size(100, 50),
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            btnBack.Click += BtnBack_Click;
            fLP_Menu.Controls.Add(btnBack);
            // Tạo các nút cho các phương thức thanh toán
            string[] phuongthuc = { "Tiền mặt", "Momo", "Chuyển khoản ngân hàng", "Thẻ tín dụng" };
            foreach (string text in phuongthuc)
            {
                Button btn = new Button
                {
                    Text = text,
                    Size = new Size(150, 60),
                    BackColor = Color.LightGreen,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                btn.Click += (s, e) =>
                {
                    switch (text)
                    {
                        case "Tiền mặt": 
                            gBHinhThucTT.Visible = true; // Hiện groupbox hình thức thanh toán
                            break;

                        case "Chuyển khoản ngân hàng":
                        case "Momo":
                            ShowQRCode(text);
                            break;
                    }
                };
                fLP_Menu.Controls.Add(btn);
            }
        }
    }
}
