using EntityDb.Entities;
using System.Data;

namespace Application.PhieuMuonSachs
{
    public interface IApplicationPhieuMuonSachs
    {
        DataTable Get_PhieuMuonSach();
        int Get_MaCuoi();
        int Them(PhieuMuonSach pPhieuMuonSach);
        int Xoa(string pMa);
        int ThemNgayTra(string pMa, string pNgayTra);
        int Sua(PhieuMuonSach pDocGia, string idx);

    }
}
