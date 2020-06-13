using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSach
    {
        //private int _MaPhieuMuon { get; set; }
        //private string _NgayMuon { get; set; }
        //private string _NgayTra { get; set; }
        //private int _MaDocGia { get; set; }
        private int _MaPhieuMuon;

        public int MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }
        private string _NgayMuon;

        public string NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        private string _NgayTra;

        public string NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        private int _MaDocGia;

        public int MaDocGia
        {
            get { return _MaDocGia; }
            set { _MaDocGia = value; }
        }




        public PhieuMuonSach(string ngayMuon, string ngayTra, int maDocGia)
        {
            _NgayMuon = ngayMuon;
            _NgayTra = ngayTra;
            _MaDocGia = maDocGia;
        }
    }
}
