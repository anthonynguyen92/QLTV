using EntityDb.Entities;
using System.Data;

namespace Application.Sachs
{
    public interface IApplicastionSach
    {
        DataTable Get_Sach();
        int Them(Sach pSach);
        int Xoa(string pMa);
        int Sua(Sach pSach, string idx);

    }
}
