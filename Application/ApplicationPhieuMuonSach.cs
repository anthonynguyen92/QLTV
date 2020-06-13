using EntityDb.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using EntityDb.Entities;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationPhieuMuonSach
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

        public async Task<int> Them(PhieuMuonSach pPhieuMuonSach)
        {
            _context.PhieuMuonSach.Add(pPhieuMuonSach);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Xoa(string pMa)
        {
            var anw = _context.PhieuMuonSach.Find(pMa);
            if (anw != null)
                _context.PhieuMuonSach.Remove(anw);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ThemNgayTra(string pMa, string pNgayTra)
        {
            var result = _context.PhieuMuonSach.Find(pMa);
            if (result != null)
            {
                result.NgayTra = pNgayTra;
                _context.PhieuMuonSach.Update(result);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<int> Sua(PhieuMuonSach pDocGia, string idx)
        {
            var result = _context.PhieuMuonSach.Find(idx);
            if (result != null)
            {
                result = pDocGia;
                _context.PhieuMuonSach.Update(result);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
