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
    public class BUS_PhieuMuonSach
    {
        DAL_PhieuMuonSach dal_PhieuMuonSach = new DAL_PhieuMuonSach();
        public bool Them(PhieuMuonSach pPhieuMuonSach)
        {
            return dal_PhieuMuonSach.Them(pPhieuMuonSach);
        }
        public bool ThemNgayTra(string pMa, string pNgayTra)
        {
            return dal_PhieuMuonSach.ThemNgayTra(pMa, pNgayTra);
        }
        public bool Xoa(string pMa)
        {
            return dal_PhieuMuonSach.Xoa(pMa);
        }
        public bool Sua(PhieuMuonSach pPhieuMuonSach, string idx)
        {
            return dal_PhieuMuonSach.Sua(pPhieuMuonSach, idx);
        }
        public DataTable Get_PhieuMuonSach()
        {
            return dal_PhieuMuonSach.Get_PhieuMuonSach();
        }
        public int Get_MaCuoi()
        {
            return dal_PhieuMuonSach.Get_MaCuoi();
        }
    }
}
