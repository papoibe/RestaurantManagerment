using System;
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
        public List<MonAn_DOL> GetAll()
        {
            List<MonAn_DOL> lst = new List<MonAn_DOL>();
            string sql = "SELECT * FROM MonAn";

            SqlDataReader dr = MyExecuteReader(sql, System.Data.CommandType.Text);
            while (dr.Read())
            {
                MonAn_DOL monAn = new MonAn_DOL(
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

        public List<MonAn_DOL> GetMonAnByLoai(int maLoai)
        {
            List<MonAn_DOL> lst = new List<MonAn_DOL>();
            string sql = "SELECT * FROM MonAn WHERE MaLoai = @MaLoai AND TrangThai = 1";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                Connect();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MonAn_DOL monAn = new MonAn_DOL(
                        dr.GetInt32(0),                 // MaMonAn
                        dr.GetString(1),                // TenMonAn
                        dr.GetInt32(2),                 // MaLoai
                        (float)dr.GetDouble(3),         // DonGia
                        dr.IsDBNull(4) ? string.Empty : dr.GetString(4), // MoTa
                        dr.GetBoolean(5)                // TrangThai
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

        
    }
}