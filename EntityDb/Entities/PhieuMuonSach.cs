using EntityDb.Configuration;
using System.Collections.Generic;

namespace EntityDb.Entities
{
    public class PhieuMuonSach
    {
        public int MaPhieuMuon { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }
        public List<ChiTietPhieuMuon> chiTietPhieuMuon { get; set; }
        public List<DocGia> DocGia { get; set; }
        public int MaDocGia { get; set; }
    }
}
