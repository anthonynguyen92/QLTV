using Application.TraSachs;
using System.Data;

namespace BUS.TraSachService
{
    public class BUS_Tra : IBUS_Tra
    {
        private readonly IApplicationTraSach _application;

        public BUS_Tra(IApplicationTraSach application)
        {
            _application = application;

        }

        public DataTable Get_SachMuon(string pMaPhieuMuon)
        {
            return _application.Get_SachMuon(pMaPhieuMuon);
        }

        public DataTable Get_DocGiaMuon()
        {
            return _application.Get_DocGiaMuon();
        }
    }
}
