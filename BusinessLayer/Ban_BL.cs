using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;   
namespace BusinessLayer
{
    public class Ban_BL
    {
        private Ban_DAL banDAL;
        public Ban_BL()
        {
            banDAL = new Ban_DAL();
        }

        public List<Ban_DTO> GetAll()
        {
            try
            {
                return banDAL.GetAll();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool CapNhatBan(Ban_DTO ban)
        {
            return banDAL.CapNhatBan(ban);
        }
    }
}
