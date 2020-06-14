using EntityDb.Entities;
using System.Data;

namespace Application.NhanViens
{
    public interface IApplicationNhanviens
    {
        DataTable Get_NhanVien();
        int Them(NhanVien pNhanVien);
        int Xoa(string pMa);
        int Sua(NhanVien pNhanVien, string idx);

    }
}
