using EntityDb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Entities
{
    public class ChiTietPhieuMuon
    {
        public int MaPhieuMuon { get; set; }
        public PhieuMuonSach PhieuMuonSach{ get; set; }
        public string MaSach { get; set; }
        public Sach Sach { get; set; }
    }

}
