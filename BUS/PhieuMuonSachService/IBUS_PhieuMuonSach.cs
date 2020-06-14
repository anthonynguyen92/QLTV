using BUS.DTO;
using System.Data;

namespace BUS.PhieuMuonSachService
{
    public interface IBUS_PhieuMuonSach
    {
        int Them(PhieuMuonSachDTO pPhieuMuonSach);
        int ThemNgayTra(string pMa, string pNgayTra);
        int Xoa(string pMa);
        int Sua(PhieuMuonSachDTO pPhieuMuonSach, string idx);
        DataTable Get_PhieuMuonSach();
        int Get_MaCuoi();

    }
}
