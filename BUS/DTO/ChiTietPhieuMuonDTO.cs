namespace BUS.DTO
{
    public class ChiTietPhieuMuonDTO
    {
        public int MaPhieuMuon { get; set; }
        public string MaSach { get; set; }

        public ChiTietPhieuMuonDTO(int mpm, string ms)
        {
            this.MaPhieuMuon = mpm;
            this.MaSach = ms;
        }
    }
}
