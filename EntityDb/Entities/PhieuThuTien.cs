using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Entities
{
    public class PhieuThuTien
    {
        public int MaPhieuThuTien { get; set; }
        public int SoTienNo { get; set; }
        public int SoTienThu { get; set; }
        public int MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public List<NhanVien> nhanViens { get; set; }
    }
}
