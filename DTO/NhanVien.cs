using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string _MaNhanVien;

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }

        private string _HoTenNhanVien;

        public string HoTenNhanVien
        {
            get { return _HoTenNhanVien; }
            set { _HoTenNhanVien = value; }
        }

        private string _NgaySinh;

        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        private int _MaBangCap;

        public int MaBangCap
        {
            get { return _MaBangCap; }
            set { _MaBangCap = value; }
        }

        public NhanVien( string pHoTenNhanVien, string pNgaySinh, string pDiaChi, string pDienThoai, int pMaBangCap)
        {
            this._HoTenNhanVien = pHoTenNhanVien;
            this._NgaySinh = pNgaySinh;
            this._DiaChi = pDiaChi;
            this._DienThoai = pDienThoai;
            this._MaBangCap = pMaBangCap;
        }

    }
}
