using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application.PhieuThuTiens
{
    public class ApplicationPhieuThuTien : IApplicationPhieuThuTien
    {
        private readonly QLDBContext _context;

        public ApplicationPhieuThuTien(QLDBContext context)
        {
            _context = context;
        }

        public DataTable Get_PhieuThuTien()
        {
            var getlist = from c in _context.PhieuThuTien
                          select c;

            return getlist.ToList().ToDataTable<PhieuThuTien>();
        }

        public int Them(PhieuThuTien pPhieuThuTien)
        {
            _context.PhieuThuTien.Add(pPhieuThuTien);
            return _context.SaveChanges();
        }

        public int Xoa(string pMa)
        {
            var anw = _context.PhieuThuTien.Find(pMa);
            if (anw != null)
                _context.PhieuThuTien.Remove(anw);
            return _context.SaveChanges();
        }

        public int Sua(PhieuThuTien pPhieuThuTien, string idx)
        {
            var result = _context.PhieuThuTien.Find(idx);
            if (result != null)
            {
                result = pPhieuThuTien;
                _context.PhieuThuTien.Update(pPhieuThuTien);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
