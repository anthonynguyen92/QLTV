using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;


namespace Application.ChiTietPhieuMuons
{
    public class ApplicationChiTietPhieuMuon: IApplicationChiTietPhieuMuon
    {
        private readonly QLDBContext _context;

        public ApplicationChiTietPhieuMuon(QLDBContext context)
        {
            _context = context;
        }

        public DataTable Get_ChiTietPhieuMuon()
        {

            var getlist = from c in _context.ChiTietPhieuMuon
                          select c;

            return getlist.ToList().ToDataTable<ChiTietPhieuMuon>();
        }

        public int Them(ChiTietPhieuMuon pChiTietPhieuMuon)
        {
            _context.ChiTietPhieuMuon.Add(pChiTietPhieuMuon);
            return _context.SaveChanges();
        }
    }
}
