using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_PhieuThuTien
    {
        DAL_PhieuThuTien dal_PhieuThuTien = new DAL_PhieuThuTien();
        public bool Them(PhieuThuTien pPhieuThuTien)
        {
            return dal_PhieuThuTien.Them(pPhieuThuTien);
        }
        public bool Xoa(string pMa)
        {
            return dal_PhieuThuTien.Xoa(pMa);
        }
        public bool Sua(PhieuThuTien pPhieuThuTien, string idx)
        {
            return dal_PhieuThuTien.Sua(pPhieuThuTien, idx);
        }
        public DataTable Get_PhieuThuTien()
        {
            return dal_PhieuThuTien.Get_PhieuThuTien();
        }
    }
}
