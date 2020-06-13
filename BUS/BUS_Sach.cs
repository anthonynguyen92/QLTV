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
    public class BUS_Sach
    {
        DAL_Sach dal_Sach = new DAL_Sach();
        public bool Them(Sach pSach)
        {
            return dal_Sach.Them(pSach);
        }
        public bool Xoa(string pMa)
        {
            return dal_Sach.Xoa(pMa);
        }
        public bool Sua(Sach pSach, string idx)
        {
            return dal_Sach.Sua(pSach, idx);
        }
        public DataTable Get_Sach()
        {
            return dal_Sach.Get_Sach();
        }
    }
}
