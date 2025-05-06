using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class ucHoaDon: UserControl
    {
        
            // Thuộc tính để lưu thông tin hóa đơn
        public HoaDonTT_DTO HoaDon { get; private set; }

        public ucHoaDon()
        {
              InitializeComponent();
        }

        public ucHoaDon(HoaDonTT_DTO hd)
            {
                InitializeComponent();
                HoaDon = hd;
                BindData(hd);

                // Gán sự kiện Click cho UserControl (tùy chọn để truyền lên các thành phần con)
                this.Click += (s, e) => { }; // Đặt rỗng để tránh lỗi, sẽ gán sự kiện bên form
                foreach (Control control in this.Controls)
                {
                    control.Click += (s, e) => this.OnClick(e);
                }
            }

            private void BindData(HoaDonTT_DTO hd)
            {
                lb_maHD.Text += hd.MaDonHang.ToString();
                lb_maTT.Text += hd.MaThanhToan.ToString();
                lb_tenBan.Text = string.IsNullOrEmpty(hd.TenBan) ? "Không xác định" : hd.TenBan;

                // Thay đổi màu nền dựa trên MaTrangThai
                switch (hd.MaTrangThai)
                {
                    case 1:
                        this.BackColor = Color.Blue;
                        break;
                    case 4:
                        this.BackColor = Color.Green;
                        break;
                    default:
                        this.BackColor = Color.Red;
                        break;
                }

                lb_gioTT.Text = hd.NgayThanhToan.ToString("HH:mm:ss");
                lb_ngayTT.Text = hd.NgayThanhToan.ToString("dd/MM/yyyy");
                lb_tenTN.Text = string.IsNullOrEmpty(hd.HoTen) ? "Không xác định" : hd.HoTen;
                lb_tongTien.Text = hd.SoTien >= 0 ? $"{hd.SoTien:N0} VND" : "0 VND";
                lb_phuongthucTT.Text = string.IsNullOrEmpty(hd.TenHinhThuc) ? "Không xác định" : hd.TenHinhThuc;
            }
        }
    }
