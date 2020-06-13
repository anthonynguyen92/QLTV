using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_BangCap
    {
        DAL_BangCap dal_BangCap = new DAL_BangCap();
        public DataTable Get_BangCap()
        {
            return dal_BangCap.Get_BangCap();
        }
        public int Get_MaBangCap(string pTenBangCap)
        {
            return dal_BangCap.Get_MaBangCap(pTenBangCap);
        }
    }
}
