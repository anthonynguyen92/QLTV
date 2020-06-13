using EntityDb.EF;
using EntityDb.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationNhanvien
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

        public async Task<int> Them(NhanVien pNhanVien)
        {
            _context.NhanViens.Add(pNhanVien);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Xoa(string pMa)
        {
            var anw = _context.NhanViens.Find(pMa);
            if (anw != null)
                _context.NhanViens.Remove(anw);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Sua(NhanVien pNhanVien, string idx)
        {
            var result = _context.NhanViens.Find(idx);
            if (result != null)
            {
                result = pNhanVien;
                _context.NhanViens.Update(result);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
