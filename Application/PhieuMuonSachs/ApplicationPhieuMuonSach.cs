using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application.PhieuMuonSachs
{
    public class ApplicationPhieuMuonSach : IApplicationPhieuMuonSachs
    {
        private readonly QLDBContext _context;

        public ApplicationPhieuMuonSach(QLDBContext context)
        {
            _context = context;
        }

        public DataTable Get_PhieuMuonSach()
        {
            var getlist = from c in _context.PhieuMuonSach
                          select c;

            return getlist.ToList().ToDataTable<PhieuMuonSach>();
        }

        public int Get_MaCuoi()
        {
            var getlist = from c in _context.PhieuMuonSach
                          select c;
            var getlast = getlist.Max(a => a.MaPhieuMuon);
            return getlast;
        }

        public int Them(PhieuMuonSach pPhieuMuonSach)
        {
            _context.PhieuMuonSach.Add(pPhieuMuonSach);
            return _context.SaveChanges();
        }

        public int Xoa(string pMa)
        {
            var anw = _context.PhieuMuonSach.Find(pMa);
            if (anw != null)
                _context.PhieuMuonSach.Remove(anw);
            return _context.SaveChanges();
        }

        public int ThemNgayTra(string pMa, string pNgayTra)
        {
            var result = _context.PhieuMuonSach.Find(pMa);
            if (result != null)
            {
                result.NgayTra = pNgayTra;
                _context.PhieuMuonSach.Update(result);
                return _context.SaveChanges();
            }
            return 0;
        }

        public int Sua(PhieuMuonSach pDocGia, string idx)
        {
            var result = _context.PhieuMuonSach.Find(idx);
            if (result != null)
            {
                result = pDocGia;
                _context.PhieuMuonSach.Update(result);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
