using BUS.DTO;
using System.Data;

namespace BUS.DocGiaService
{
    public interface IBUS_DocGia
    {
        int Them(DocGiaDTO pDocGia);
        int Xoa(string pMa);
        int Sua(DocGiaDTO pDocGia, string idx);
        DataTable Get_DocGia();

    }
}
