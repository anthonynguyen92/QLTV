using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityDb.Entities
{
    public class DocGia
    {
        public int MaDocGia { get; set; }
        public string HoTenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public String DiaChi { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        public DateTime NgayLapThe{ get; set; }
        public DateTime NgayHetHan { get; set; }
        public int Tien { get; set; }
        public PhieuMuaSach phieuMuaSach { get; set; }
        public int MaPhieuMuon { get; set; }

    }
}
