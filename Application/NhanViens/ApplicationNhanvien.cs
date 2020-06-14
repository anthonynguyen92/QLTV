using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application.NhanViens
{
    public class ApplicationNhanvien: IApplicationNhanviens
    {
        private readonly QLDBContext _context;

        public ApplicationNhanvien(QLDBContext context)
        {
            _context = context;
        }
        public DataTable Get_NhanVien()
        {

            var getlist = from c in _context.NhanViens
                          select c;

            return getlist.ToList().ToDataTable<NhanVien>();
        }

        public int Them(NhanVien pNhanVien)
        {
            _context.NhanViens.Add(pNhanVien);
            return _context.SaveChanges();
        }

        public int Xoa(string pMa)
        {
            var anw = _context.NhanViens.Find(pMa);
            if (anw != null)
                _context.NhanViens.Remove(anw);
            return _context.SaveChanges();
        }

        public int Sua(NhanVien pNhanVien, string idx)
        {
            var result = _context.NhanViens.Find(idx);
            if (result != null)
            {
                result = pNhanVien;
                _context.NhanViens.Update(result);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
