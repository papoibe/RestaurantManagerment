using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class DonHang_DOL
    {
        public int MaDonHang { get; set; }
        public int MaBan { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayTao { get; set; }
        
        public bool TrangThai { get; set; }
        public float GiamGia { get; set; }
        public float TongTien { get; set; }

        public string GhiChu { get; set; }
        public DonHang_DOL(int maDonHang, int maBan, int maNhanVien, DateTime ngayTao, bool trangThai, float giamGia, float tongTien, string ghiChu)
        {
            MaDonHang = maDonHang;
            MaBan = maBan;
            MaNhanVien = maNhanVien;
            NgayTao = ngayTao;
            TrangThai = trangThai;
            GiamGia = giamGia;
            TongTien = tongTien;
            GhiChu = ghiChu;
        }
    }
}
