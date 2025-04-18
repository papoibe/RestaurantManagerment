using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class MonAn_MaDH_DTO
    {
        public string TenMonAn { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public MonAn_MaDH_DTO(string tenMonAn, int soLuong, float donGia, float thanhTien)
        {
            TenMonAn = tenMonAn;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
