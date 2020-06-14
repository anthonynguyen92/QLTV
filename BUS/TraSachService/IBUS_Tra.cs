using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.TraSachService
{
    public interface IBUS_Tra
    {
        DataTable Get_SachMuon(string pMaPhieuMuon);
        DataTable Get_DocGiaMuon();
    }
}
