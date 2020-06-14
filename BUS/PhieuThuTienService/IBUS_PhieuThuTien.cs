using BUS.DTO;
using System.Data;

namespace BUS.PhieuThuTienService
{
    public interface IBUS_PhieuThuTien
    {
        int Them(PhieuThuTienDTO pPhieuThuTien);
        int Xoa(string pMa);
        int Sua(PhieuThuTienDTO pPhieuThuTien, string idx);
        DataTable Get_PhieuThuTien();

    }
}
