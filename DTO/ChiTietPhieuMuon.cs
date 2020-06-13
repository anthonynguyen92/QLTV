using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuMuon
    {
        //private int _MaSach { get; set; }
        //private int _MaPhieuMuon { get; set; }
        private int _MaSach;

        public int MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }

        private int _MaPhieuMuon;

        public int MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }


        public ChiTietPhieuMuon(int maSach, int maPhieuMuon)
        {
            _MaSach = maSach;
            _MaPhieuMuon = maPhieuMuon;
        }
        
    }
}
