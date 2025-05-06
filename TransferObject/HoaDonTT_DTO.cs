using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class HoaDonTT_DTO
    {
        public int MaDonHang { get; set; }
        public int MaThanhToan { get; set; }
        public string TenBan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int MaTrangThai { get; set; }
        public float SoTien { get; set; }
        public string TenHinhThuc { get; set; }

        public HoaDonTT_DTO(int maDonHang, int maThanhToan, string tenBan, string hoTen, DateTime ngayThanhToan, int maTrangThai, float soTien, string tenHinhThuc)
        {
            MaDonHang = maDonHang;
            MaThanhToan = maThanhToan;
            TenBan = tenBan ?? string.Empty;
            HoTen = hoTen ?? string.Empty;
            NgayThanhToan = ngayThanhToan;
            MaTrangThai = maTrangThai;
            SoTien = soTien;
            TenHinhThuc = tenHinhThuc ?? string.Empty;
        }


        //MaBan = maBan;
        //MaNhanVien = maNhanVien;
        //NgayLap = ngayLap;
        //MaTrangThai = maTrangThai;
        //GiamGia = giamGia;
        //TongTien = tongTien;
        //GhiChu = ghiChu;
        //public HoaDonTT_DTO() { }
    }
}
