using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObject;
namespace DataLayer
{
    class LoaiMonAn_DAL: DataProvider
    {
        public List<LoaiMonAn_DOL> GetAll()
        {
            List<LoaiMonAn_DOL> lst = new List<LoaiMonAn_DOL>();
            string sql = "SELECT * FROM LoaiMonAn";
            SqlDataReader dr = MyExecuteReader(sql, System.Data.CommandType.Text);
            while (dr.Read())
            {
                LoaiMonAn_DOL loaiMonAn = new LoaiMonAn_DOL(dr.GetInt32(0), dr.GetString(1), dr.IsDBNull(2) ? string.Empty : dr.GetString(2));
                lst.Add(loaiMonAn);
            }
            dr.Close();
            return lst;
        }
        public MonAn_DOL GetMonByID(int id)
        {

            return null;
        }
    }

}
