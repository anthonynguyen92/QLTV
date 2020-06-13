using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_PhieuMuonSach : DBConnect
    {
        public DataTable Get_PhieuMuonSach()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuMuonSach", _sqlConn);
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
        public int Get_MaCuoi()
        {
            _sqlConn.Open();
            string sqlPHIEUMUONSACH = "select top(1) MaPhieuMuon from PhieuMuonSach order by MaPhieuMuon desc";
            SqlCommand cmdBC = new SqlCommand(sqlPHIEUMUONSACH, _sqlConn);
            SqlDataReader rdBC;
            rdBC = cmdBC.ExecuteReader();
            ArrayList arrBC = new ArrayList(); //chứa tên(string) các loại bằng cấp
            while (rdBC.Read())
            {
                arrBC.Add(rdBC.GetInt32(0).ToString());
            }
            rdBC.Close();
            cmdBC.Dispose();
            _sqlConn.Close();

            return Int32.Parse(arrBC[0].ToString());
        }

        public bool Them(PhieuMuonSach pPhieuMuonSach)
        {
            try
            {
                string sql = string.Format("INSERT INTO PhieuMuonSach "
                + "VALUES (N'{0}',NULL,N'{2}')",
                pPhieuMuonSach.NgayMuon,pPhieuMuonSach.NgayTra, pPhieuMuonSach.MaDocGia);
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
        public bool ThemNgayTra(string pMa, string pNgayTra)
        {
            try
            {
                string sql = string.Format("UPDATE PhieuMuonSach SET NgayTra = '{0}' WHERE MaPhieuMuon = '{1}'",
                pNgayTra, pMa);
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

        public bool Xoa(string pMa)
        {
            try
            {
                string sql = "DELETE FROM PhieuMuonSach WHERE MaPhieuMuon = " + pMa;
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

        public bool Sua(PhieuMuonSach pPhieuMuonSach, string idx)
        {
            try
            {
                string sql = string.Format("UPDATE PhieuMuonSach " +
                "SET NgayMuon = '{0}', NgayTra = '{1}', MaDocGia = '{2}' " +
                "WHERE MaPhieuMuon = " + idx,
                pPhieuMuonSach.NgayMuon, pPhieuMuonSach.NgayTra,
                pPhieuMuonSach.MaDocGia);
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