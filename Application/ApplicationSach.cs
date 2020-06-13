using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application
{
    public class ApplicationSach
    {
        private readonly QLDBContext _context;

        public ApplicationSach(QLDBContext context)
        {
            _context = context;
        }

        public DataTable Get_Sach()
        {
            var getlist = from c in _context.Sach
                          select c;

            return getlist.ToList().ToDataTable<Sach>();
        }

        public int Them(Sach pSach)
        {
            _context.Sach.Add(pSach);
            return _context.SaveChanges();
        }

        public int Xoa(string pMa)
        {
            var anw = _context.Sach.Find(pMa);
            if (anw != null)
                _context.Sach.Remove(anw);
            return _context.SaveChanges();
        }

        public int Sua(Sach pSach, string idx)
        {
            var result = _context.Sach.Find(idx);
            if (result != null)
            {
                result = pSach;
                _context.Sach.Update(result);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
