using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TransferObject;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ThanhToan_DAL : DataProvider
    {
        public List<HinhThucTT_DTO> GetHinhThucTT()
        {
            List<HinhThucTT_DTO> lst = new List<HinhThucTT_DTO>();
            string sql = "SELECT * FROM HinhThucThanhToan";
            SqlDataReader dr = MyExecuteReader(sql, CommandType.Text);
            while (dr.Read())
            {
                HinhThucTT_DTO hinhThucTT = new HinhThucTT_DTO(dr.GetInt32(0), dr.GetString(1), dr.IsDBNull(2) ? string.Empty : dr.GetString(2), dr.GetBoolean(3));
                lst.Add(hinhThucTT);
            }
            dr.Close();
            return lst;
        }
        public List<ThanhToan_DTO> GetAll()
        {
            List<ThanhToan_DTO> lst = new List<ThanhToan_DTO>();
            string sql = "SELECT * FROM ThanhToan";
            SqlDataReader dr = MyExecuteReader(sql, CommandType.Text);
            while (dr.Read())
            {
                ThanhToan_DTO thanhToan = new ThanhToan_DTO(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), (float)dr.GetDouble(3), dr.GetDateTime(4), dr.IsDBNull(5) ? string.Empty : dr.GetString(5));
                lst.Add(thanhToan);
            }
            dr.Close();
            return lst;
        }


        public bool InsertThanhToan(ThanhToan_DTO thanhToan)
        {
            string sql = "INSERT INTO ThanhToan( MaDonHang, MaNhanVien, MaHinhThuc, SoTien, NgayThanhToan, GhiChu) VALUES( @MaDonHang, @MaNhanVien, @MaHinhThuc, @SoTien, @NgayThanhToan, @GhiChu)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaDonHang", thanhToan.MaDonHang);
            cmd.Parameters.AddWithValue("@MaNhanVien", thanhToan.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaHinhThuc", thanhToan.MaHinhThucTT);
            cmd.Parameters.AddWithValue("@SoTien", thanhToan.SoTien);
            cmd.Parameters.AddWithValue("@NgayThanhToan", thanhToan.NgayThanhToan);
            cmd.Parameters.AddWithValue("@GhiChu", thanhToan.GhiChu);
            try
            {
                Connect();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
               DisConnect();
            }
        }
    }
}
