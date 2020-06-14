using EntityDb.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Entities
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public string TriGia { get; set; }
        public string NgayNhap { get; set; }
        public List<ChiTietPhieuMuon> chiTietPhieuMuon { get; set; }
    }
}
