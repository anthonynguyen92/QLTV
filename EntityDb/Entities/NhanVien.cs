using System.Collections.Generic;

namespace EntityDb.Entities
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public List<BangCap> Bangcaps{ get; set; }
        public PhieuThuTien PhieuThuTien { get; set; }
        public int MaPhieuThuTien { get; set; }
    }
}
