using EntityDb.Entities;
using System.Data;

namespace Application.DocGias
{
    public interface IApplicationDocGia
    {
        DataTable Get_DocGia();
        int Them(DocGia pDocGia);
        int Xoa(string pMa);
        int Sua(DocGia pDocGia, string idx);
        int Get_MaDocGia(string pHoTenDocGia);
        string Get_TenDocGia(string pMa);
    }
}
