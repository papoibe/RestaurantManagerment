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
    public partial class FrmQuanLyHoaDon: Form
    {
        private List<DonHang_DTO> listDonHang;
        private DonHang_BL DonHang_BL = new DonHang_BL();
        private List<ChiTietDonHang_DTO> listChiTietDonHang;
        private ThanhToan_BL thanhToan_BL = new ThanhToan_BL();
        private MonAn_BL monAnBL = new MonAn_BL();
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Xóa các UserControl cũ (nếu có)
                fLP_HD.Controls.Clear();

                // Lấy danh sách hóa đơn từ thanhToan_BL
                var danhSachHoaDon = thanhToan_BL.GetHD();

                // Duyệt qua danh sách hóa đơn và tạo ucHoaDon
                foreach (var hd in danhSachHoaDon)
                {
                    ucHoaDon uc = new ucHoaDon(hd);
                    uc.Click += (s, e2) =>
                    {
                        if (s is ucHoaDon clickedUc)
                        {
                            var hoaDon = clickedUc.HoaDon;
                            if (hoaDon != null)
                            {
                                var donhang = DonHang_BL.GetById(hoaDon.MaDonHang);
                                lb_GiamGia.Text = donhang.GiamGia.ToString();
                                lb_Tong.Text = donhang.TongTien.ToString();
                                lb_MD.Text = donhang.MaDonHang.ToString();
                                switch ((int)hoaDon.MaTrangThai)
                                {
                                    case 1:
                                    case 2:
                                    case 3: 
                                        lb_TrangThai.Text = "Chưa thanh toán";
                                        break;
                                    case 4:
                                        lb_TrangThai.Text = "Đã thanh toán";
                                        break;
                                    case 5:
                                        lb_TrangThai.Text = "Đã hủy";
                                        break;
                                    default:
                                        lb_TrangThai.Text = "Không xác định";
                                        break;
                                } 
                                lb_PPTT.Text = hoaDon.TenHinhThuc.ToString();
                                var chiTiet = monAnBL.GetMonAnByMaDH(hoaDon.MaDonHang);
                                dgv_chiTiet.Rows.Clear();
                                foreach (var monAn in chiTiet)
                                {
                                    dgv_chiTiet.Rows.Add(monAn.MaChiTiet,monAn.SoLuong, monAn.TenMonAn, monAn.ThanhTien);
                                }
                            }
                        }
                    };
                    fLP_HD.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            // nghiệp vụ mở rộng ( in hóa đơn) khi có ứng dụng bên thứ 3
        }
    }
}
