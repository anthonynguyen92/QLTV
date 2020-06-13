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
    public class DAL_PhieuThuTien :DBConnect
    {
        public DataTable Get_PhieuThuTien()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThuTien", _sqlConn);
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


        public bool Them(PhieuThuTien pPhieuThuTien)
        {
            try
            {
                string sql = string.Format("INSERT INTO PhieuThuTien "
                + "VALUES (N'{0}','{1}',N'{2}','{3}','{4}','{5}','{6}')",
                pPhieuThuTien.MaPhieuThuTien, pPhieuThuTien.SoTienNo,
                pPhieuThuTien.SoTienThu, pPhieuThuTien.MaDocGia, pPhieuThuTien.MaNhanVien);
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
                string sql = "DELETE FROM PhieuThuTien WHERE MaPhieuThuTien = " + pMa;
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

        public bool Sua(PhieuThuTien pPhieuThuTien, string idx)
        {
            try
            {
                string sql = string.Format("UPDATE PhieuThuTien " +
                "SET SoTienNo = '{0}', SoTienThu = '{1}', MaDocGia = '{2}', MaNhanVien = '{3}' " +
                "WHERE MaPhieuThuTien = " + idx,
                pPhieuThuTien.SoTienNo, pPhieuThuTien.SoTienThu,
                pPhieuThuTien.MaDocGia, pPhieuThuTien.MaNhanVien);
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
