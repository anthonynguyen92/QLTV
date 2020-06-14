namespace BUS.DTO
{
    public class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public string TriGia { get; set; }
        public string NgayNhap { get; set; }
        public SachDTO(string ms, string ts, string tggia, string nanmsb, string nxb, string tg, string nn)
        {
            this.MaSach = ms;
            this.TenSach = ts;
            this.TacGia = tggia;
            this.NamXuatBan = nanmsb;
            this.NhaXuatBan = nxb;
            this.TriGia = tg;
            this.NgayNhap = nn;
        }

    }
}
