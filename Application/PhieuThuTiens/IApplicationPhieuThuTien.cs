using EntityDb.Entities;
using System.Data;

namespace Application.PhieuThuTiens
{
    public interface IApplicationPhieuThuTien
    {
        DataTable Get_PhieuThuTien();
        int Them(PhieuThuTien pPhieuThuTien);
        int Xoa(string pMa);
        int Sua(PhieuThuTien pPhieuThuTien, string idx);

    }
}
