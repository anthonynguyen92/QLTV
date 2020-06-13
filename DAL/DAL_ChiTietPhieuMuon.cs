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
    public class DAL_ChiTietPhieuMuon : DBConnect
    {
        public DataTable Get_ChiTietPhieuMuon()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietPhieuMuon", _sqlConn);
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


        public bool Them(ChiTietPhieuMuon pChiTietPhieuMuon)
        {
            try
            {
                string sql = string.Format("INSERT INTO ChiTietPhieuMuon "
                + "VALUES ('{0}','{1}')",
                pChiTietPhieuMuon.MaSach, pChiTietPhieuMuon.MaPhieuMuon);
                SqlCommand cmd = new SqlCommand(sql, _sqlConn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}