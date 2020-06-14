using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application.DocGias
{
    public class ApplicationDocGia : IApplicationDocGia
    {
        private readonly QLDBContext _context;

        public ApplicationDocGia(QLDBContext context)
        {
            _context = context;
        }
        public DataTable Get_DocGia()
        {
            var getlist = from c in _context.DocGia
                          select c;

            return getlist.ToList().ToDataTable<DocGia>();
        }

        public int Them(DocGia pDocGia)
        {
            _context.DocGia.Add(pDocGia);
            return _context.SaveChanges();
        }

        public int Xoa(string pMa)
        {
            var anw = _context.DocGia.Find(pMa);
            if (anw != null)
                _context.DocGia.Remove(anw);
            return _context.SaveChanges();
        }

        public int Sua(DocGia pDocGia, string idx)
        {
            var result = _context.DocGia.Find(idx);
            if (result != null)
            {
                result = pDocGia;
                _context.DocGia.Update(result);
                return _context.SaveChanges();
            }
            return 0;
        }

        public int Get_MaDocGia(string pHoTenDocGia)
        {
            var result = from c in _context.DocGia
                         where c.HoTenDocGia.Contains(pHoTenDocGia)
                         select c.MaDocGia;
            return result.First();
        }

        public string Get_TenDocGia(string pMa)
        {
            var result = from c in _context.DocGia
                         where c.HoTenDocGia.Contains(pMa)
                         select c.HoTenDocGia;
            return result.First();
        }
    }
}
