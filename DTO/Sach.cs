using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }

        private string _TenSach;

        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }

        private string _TacGia;

        public string TacGia
        {
            get { return _TacGia; }
            set { _TacGia = value; }
        }

        private string _NamXuatBan;

        public string NamXuatBan
        {
            get { return _NamXuatBan; }
            set { _NamXuatBan = value; }
        }

        private string _NhaXuatBan;

        public string NhaXuatBan
        {
            get { return _NhaXuatBan; }
            set { _NhaXuatBan = value; }
        }

        private string _TriGia;

        public string TriGia
        {
            get { return _TriGia; }
            set { _TriGia = value; }
        }

        private string _NgayNhap;

        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        
        public Sach(string pTenSach, string pTacGia, string pNamXuatBan, string pNhaXuatBan, string pTriGia, string pNgayNhap)
        {
            this._TenSach = pTenSach;
            this._TacGia = pTacGia;
            this._NamXuatBan = pNamXuatBan;
            this._NhaXuatBan = pNhaXuatBan;
            this._TriGia = pTriGia;
            this._NgayNhap = pNgayNhap;
        }
    }
}
