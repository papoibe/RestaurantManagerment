﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class MonAn_DAL : DataProvider
    {
        public List<MonAn_DTO> GetAll()
        {
            List<MonAn_DTO> lst = new List<MonAn_DTO>();
            string sql = "SELECT * FROM MonAn";

            SqlDataReader dr = MyExecuteReader(sql, System.Data.CommandType.Text);
            while (dr.Read())
            {
                MonAn_DTO monAn = new MonAn_DTO(
                    dr.GetInt32(0),                 // MaMonAn
                    dr.GetString(1),                // TenMonAn
                    dr.GetInt32(2),                 // MaLoai
                    (float)dr.GetDouble(3),         // DonGia
                    dr.IsDBNull(4) ? string.Empty : dr.GetString(4), // MoTa
                    dr.GetBoolean(6)                // TrangThai
                );
                lst.Add(monAn);
            }
            dr.Close();
            return lst;
        }

        public List<MonAn_DTO> GetMonAnByLoai(int maLoai)
        {
            List<MonAn_DTO> lst = new List<MonAn_DTO>();
            string sql = "SELECT * FROM MonAn WHERE MaLoai = @MaLoai AND TrangThai = 1";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                Connect();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MonAn_DTO monAn = new MonAn_DTO(
                        dr.GetInt32(0),                 // MaMonAn
                        dr.GetString(1),                // TenMonAn
                        dr.GetInt32(2),                 // MaLoai
                        (float)dr.GetDouble(3),         // DonGia
                        dr.IsDBNull(4) ? string.Empty : dr.GetString(4), // MoTa
                        dr.GetBoolean(6)                // TrangThai
                    );
                    lst.Add(monAn);
                }
                dr.Close();
                return lst;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy món ăn theo loại: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }
        public MonAn_DTO GetMonAnByID(int maMonAn)
        {
            string sql = "SELECT * FROM MonAn WHERE MaMonAn = @MaMonAn";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
            Connect();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MonAn_DTO monAn = new MonAn_DTO(
                    dr.GetInt32(0),                 // MaMonAn
                    dr.GetString(1),                // TenMonAn
                    dr.GetInt32(2),                 // MaLoai
                    (float)dr.GetDouble(3),         // DonGia
                    dr.IsDBNull(4) ? string.Empty : dr.GetString(4), // MoTa
                    dr.GetBoolean(6)                // TrangThai
                );
                dr.Close();
                return monAn;
            }
            else
            {
                dr.Close();
                return null;
            }


        }
        public List<MonAn_MaDH_DTO> GetMonByMaDH(int MaDH)
        {
            List<MonAn_MaDH_DTO> lst = new List<MonAn_MaDH_DTO>();
            string sql = "select m.TenMonAn, ct.SoLuong, ct.DonGia, ct.ThanhTien from MonAn m, ChiTietDonHang ct where m.MaMonAn = ct.MaMonAn And ct.MaDonHang = @MaDH";
            try { 
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaDH", MaDH);
                Connect();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var monAn = new MonAn_MaDH_DTO(
                        dr.GetString(0),                // TenMonAn
                        dr.GetInt32(1),                 // SoLuong
                        (float)dr.GetDouble(2),         // DonGia
                        (float)dr.GetDouble(3)       // TrangThai
                    );
                    lst.Add(monAn);
                }
                dr.Close();
                return lst;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi lấy món ăn theo mã đơn hàng: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }
    }
}