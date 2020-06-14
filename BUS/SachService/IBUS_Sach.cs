using BUS.DTO;
using System.Data;

namespace BUS.SachService
{
    public interface IBUS_Sach
    {
        int Them(SachDTO pSach);
        int Xoa(string pMa);
        int Sua(SachDTO pSach, string idx);
        DataTable Get_Sach();

    }
}
