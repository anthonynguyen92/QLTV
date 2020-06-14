namespace BUS.DTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int MaPhieuThuTien { get; set; }

        public NhanVienDTO(string code, string name, string birth, string addr, string phone, int codeP)
        {
            this.MaNhanVien = code;
            this.HoTenNhanVien = name;
            this.NgaySinh = birth;
            this.DiaChi = addr;
            this.DienThoai = phone;
            this.MaPhieuThuTien = codeP;
        }
    }
}
