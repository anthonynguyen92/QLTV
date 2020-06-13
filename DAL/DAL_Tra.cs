using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Tra : DBConnect
    {
        public DataTable Get_SachMuon(string pMaPhieuMuon)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select s.* from ChiTietPhieuMuon c, Sach s where c.MaSach = s.MaSach and c.MaPhieuMuon in (select MaPhieuMuon from PhieuMuonSach where MaPhieuMuon = " + pMaPhieuMuon + ")", _sqlConn);
                DataSet ds = new DataSet();
                //DataTable ds = new DataTable();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public DataTable Get_DocGiaMuon()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select DISTINCT d.* from DocGia d, PhieuMuonSach p where p.MaDocGia = d.MaDocGia and NgayTra is null", _sqlConn);
                DataSet ds = new DataSet();
                //DataTable ds = new DataTable();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }
    }
}
