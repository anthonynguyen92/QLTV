using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTien
    {
        private int _MaPhieuThuTien;

        public int MaPhieuThuTien
        {
            get { return _MaPhieuThuTien; }
            set { _MaPhieuThuTien = value; }
        }
        private int _SoTienNo;

        public int SoTienNo
        {
            get { return _SoTienNo; }
            set { _SoTienNo = value; }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        private int _SoTienThu;

        public int SoTienThu
        {
            get { return _SoTienThu; }
            set { _SoTienThu = value; }
        }
        private int _MaDocGia;

        public int MaDocGia
        {
            get { return _MaDocGia; }
            set { _MaDocGia = value; }
        }
        private int _MaNhanVien;

        public int MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }


        //private int _MaPhieuThuTien { get; set; }
        //private int _SoTienNo { get; set; }
        //private int _SoTienThu { get; set; }
        //private int _MaDocGia { get; set; }
        //private int _MaNhanVien { get; set; }
        

        public PhieuThuTien(int soTienNo, int soTienThu, int maDocGia, int maNhanVien)
        {
            _SoTienNo = soTienNo;
            _SoTienThu = soTienThu;
            _MaDocGia = maDocGia;
            _MaNhanVien = maNhanVien;
        }
    }
}
