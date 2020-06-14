using System.Data;

namespace Application.TraSachs
{
    public interface IApplicationTraSach
    {
        DataTable Get_SachMuon(string pMaPhieuMuon);
        DataTable Get_DocGiaMuon();
    }
}
