using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChiTietPhieuMuonService
{
    public interface IBUS_ChiTietPhieuMuon
    {
        int Them(ChiTietPhieuMuonDTO pChiTietPhieuMuon);
        DataTable Get_NhanVien();
    }
}
