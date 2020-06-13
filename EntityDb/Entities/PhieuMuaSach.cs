using System.Collections.Generic;

namespace EntityDb.Entities
{
    public class PhieuMuaSach
    {
        public int MaPhieuMua { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }
        public List<Sach> Sach{ get; set; }
        public string? MaSach { get; set; }
        public List<DocGia> DocGia { get; set; }
        public int MaDocGia { get; set; }
    }
}
