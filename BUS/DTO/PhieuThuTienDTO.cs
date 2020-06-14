namespace BUS.DTO
{
    public class PhieuThuTienDTO
    {
        public int MaPhieuThuTien { get; set; }
        public int SoTienNo { get; set; }
        public int SoTienThu { get; set; }
        public int MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public PhieuThuTienDTO(int m, int s, int st, int mdg, string mnv)
        {
            this.MaDocGia = mdg;
            this.MaNhanVien = mnv;
            this.SoTienNo = s;
            this.SoTienThu = st;
            this.MaPhieuThuTien = m;
        }
    }
}
