using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.NhanVienService
{
    public interface IBUS_NhanVien
    {
        int Them(NhanVienDTO pNhanVien);
        int Xoa(string pMa);
        DataTable Get_NhanVien();
        int Sua(NhanVienDTO pNhanVien, string idx);
    }
}
