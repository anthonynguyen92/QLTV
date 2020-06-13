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
    public class BUS_ChiTietPhieuMuon
    {
        DAL_ChiTietPhieuMuon dal_ChiTietPhieuMuon = new DAL_ChiTietPhieuMuon();
        public bool Them(ChiTietPhieuMuon pChiTietPhieuMuon)
        {
            return dal_ChiTietPhieuMuon.Them(pChiTietPhieuMuon);
        }
        public DataTable Get_NhanVien()
        {
            return dal_ChiTietPhieuMuon.Get_ChiTietPhieuMuon();
        }
    }
}
