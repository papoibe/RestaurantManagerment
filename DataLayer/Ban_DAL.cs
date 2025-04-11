using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class Ban_DAL:DataProvider
    {
        public List<Ban_DTO> GetAll()
        {
            List<Ban_DTO> lst = new List<Ban_DTO>();
            string sql = "SELECT * FROM Ban";
           
            SqlDataReader dr = MyExecuteReader(sql,System.Data.CommandType.Text);
            while (dr.Read())
            {
                Ban_DTO ban = new Ban_DTO(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetBoolean(3), dr.IsDBNull(4) ? string.Empty : dr.GetString(4));
                lst.Add(ban);
            }
            dr.Close();
            return lst;
        }
        public bool CapNhatBan(Ban_DTO ban)
        {
            string sql = "UPDATE Ban SET TenBan = @TenBan, TrangThai = @TrangThai WHERE MaBan = @MaBan";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@MaBan", ban.MaBan);
                cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
                cmd.Parameters.AddWithValue("@TrangThai", ban.TrangThai);

                Connect();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật bàn: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }

    }
}
