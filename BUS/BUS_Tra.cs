using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Tra
    {
        DAL_Tra dal_Tra = new DAL_Tra();
        public DataTable Get_SachMuon(string pMaPhieuMuon)
        {
            return dal_Tra.Get_SachMuon(pMaPhieuMuon);
        }
        public DataTable Get_DocGiaMuon()
        {
            return dal_Tra.Get_DocGiaMuon();
        }
    }
}
