using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        private string _MaDocGia;

        public string MaDocGia
        {
            get { return _MaDocGia; }
            set { _MaDocGia = value; }
        }

        private string _HoTenDocGia;

        public string HoTenDocGia
        {
            get { return _HoTenDocGia; }
            set { _HoTenDocGia = value; }
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

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _NgayLapThe;

        public string NgayLapThe
        {
            get { return _NgayLapThe; }
            set { _NgayLapThe = value; }
        }

        private string _NgayHetHan;

        public string NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }

        private string _TienNo;

        public string TienNo
        {
            get { return _TienNo; }
            set { _TienNo = value; }
        }


        public DocGia(string pHoTenDocGia, string pNgaySinh, string pDiaChi, string pEmail, string pNgayLapThe, string pNgayHetHan, string pTienNo)
        {
            this._HoTenDocGia = pHoTenDocGia;
            this._NgaySinh = pNgaySinh;
            this._DiaChi = pDiaChi;
            this._Email = pEmail;
            this._NgayLapThe = pNgayLapThe;
            this._NgayHetHan = pNgayHetHan;
            this._TienNo = pTienNo;
        }
    }
}
