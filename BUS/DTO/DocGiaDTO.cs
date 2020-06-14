using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class DocGiaDTO
    {
        public int MaDocGia { get; set; }
        public string HoTenDocGia { get; set; }
        public DateTime? NgaySinh { get; set; }
        public String DiaChi { get; set; }
        public String Email { get; set; }
        public DateTime? NgayLapThe { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public int Tien { get; set; }
        public int? MaPhieuMuon { get; set; }

        public DocGiaDTO(int mdg, string ht,DateTime nsinh,string dc,string email,DateTime nl,DateTime nhh, int price)
        {
            this.MaDocGia = mdg;
            this.HoTenDocGia = ht;
            this.NgaySinh = nsinh;
            this.DiaChi = dc;
            this.Email = email;
            this.NgayLapThe = nl;
            this.NgayHetHan = nhh;
            this.Tien = price;
        }
    }
}
