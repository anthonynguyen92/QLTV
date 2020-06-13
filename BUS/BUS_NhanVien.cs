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
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        public bool Them(NhanVien pNhanVien)
        {
            return dal_NhanVien.Them(pNhanVien);
        }
        public bool Xoa(string pMa)
        {
            return dal_NhanVien.Xoa(pMa);
        }
        public bool Sua(NhanVien pNhanVien, string idx)
        {
            return dal_NhanVien.Sua(pNhanVien, idx);
        }
        public DataTable Get_NhanVien()
        {
            return dal_NhanVien.Get_NhanVien();
        }
    }
}
