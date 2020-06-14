using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DTO
{
    public class PhieuMuonSachDTO
    {
        public int MaPhieuMuon { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }
        public int MaDocGia { get; set; }

        public PhieuMuonSachDTO(int code,string effect,string expire,int codeM)
        {
            this.MaPhieuMuon = code;
            this.NgayMuon = effect;
            this.NgayTra = expire;
            this.MaDocGia = codeM ;
        }
    }
}
