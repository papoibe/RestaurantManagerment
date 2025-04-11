using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class MonAn_BL
    {
        private MonAn_DAL monAnDAL;

        public MonAn_BL()
        {
            monAnDAL = new MonAn_DAL();
        }

        public List<MonAn_DOL> GetAll()
        {
            return monAnDAL.GetAll();
        }

        public List<MonAn_DOL> GetMonAnByLoai(int maLoai)
        {
            return monAnDAL.GetMonAnByLoai(maLoai);
        }
    }
}