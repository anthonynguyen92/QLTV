using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DocGia
    {
        DAL_DocGia dal_DocGia = new DAL_DocGia();
        public bool Them(DocGia pDocGia)
        {
            return dal_DocGia.Them(pDocGia);
        }
        public bool Xoa(string pMa)
        {
            return dal_DocGia.Xoa(pMa);
        }
        public bool Sua(DocGia pDocGia, string idx)
        {
            return dal_DocGia.Sua(pDocGia, idx);
        }
        public DataTable Get_DocGia()
        {
            return dal_DocGia.Get_DocGia();
        }
        public int Get_MaDocGia(string pHoTenDocGia)
        {
            return dal_DocGia.Get_MaDocGia(pHoTenDocGia);
        }
        public string Get_TenDocGia(string pMa)
        {
            return dal_DocGia.Get_TenDocGia(pMa);
        }
    }
}
