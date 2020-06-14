using EntityDb.EF;
using EntityDb.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Application.TraSachs
{
    public class ApplicationTraSach : IApplicationTraSach
    {
        private readonly QLDBContext _context;

        public ApplicationTraSach(QLDBContext context)
        {
            _context = context;
        }
        
        public DataTable Get_SachMuon(string pMaPhieuMuon)
        {
            var getlistc = from c in _context.ChiTietPhieuMuon
                           join s in _context.Sach on c.MaSach equals s.MaSach
                           join p in _context.PhieuMuonSach on c.MaPhieuMuon equals p.MaPhieuMuon
                           select s;

            return getlistc.ToList().ToDataTable<Sach>();
        }

        public DataTable Get_DocGiaMuon()
        {
            var getlistc = from d in _context.DocGia
                           join p in _context.PhieuMuonSach on d.MaDocGia equals p.MaDocGia
                           where p.NgayTra == null
                           select d;

            return getlistc.ToList().ToDataTable<DocGia>();
        }
    }
}
