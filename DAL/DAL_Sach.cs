using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Sach : DBConnect
    {
        public DataTable Get_Sach()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Sach", _sqlConn);
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


        public bool Them(Sach pSach)
        {
            try
            {
                string sql = string.Format("INSERT INTO Sach "
                + "VALUES (N'{0}','{1}',N'{2}','{3}','{4}','{5}')",
                pSach.TenSach, pSach.TacGia,
                pSach.NamXuatBan, pSach.NhaXuatBan, pSach.TriGia, pSach.NgayNhap);
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
                string sql = "DELETE FROM Sach WHERE MaSach = " + pMa;
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

        public bool Sua(Sach pSach, string idx)
        {
            try
            {
                string sql = string.Format("UPDATE Sach " +
                "SET TenSach = '{0}', TacGia = '{1}', NamXuatBan = '{2}', NhaXuatBan = '{3}', TriGia = '{4}', NgayNhap = '{5}' " +
                "WHERE MaSach = " + idx,
                pSach.TenSach, pSach.TacGia,
                pSach.NamXuatBan, pSach.NhaXuatBan, pSach.TriGia, pSach.NgayNhap);
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
