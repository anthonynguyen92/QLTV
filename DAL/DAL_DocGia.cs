using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Collections;

namespace DAL
{
    public class DAL_DocGia : DBConnect
    {
        public DataTable Get_DocGia()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DocGia", _sqlConn);
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

        
        public bool Them(DocGia pDocGia)
        {
            try
            {
                string sql = string.Format("INSERT INTO DocGia "
                + "VALUES (N'{0}','{1}',N'{2}','{3}','{4}','{5}','{6}')",
                pDocGia.HoTenDocGia, pDocGia.NgaySinh,
                pDocGia.DiaChi, pDocGia.Email, pDocGia.NgayLapThe, pDocGia.NgayHetHan, pDocGia.TienNo);
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
                string sql = "DELETE FROM DocGia WHERE MaDocGia = " + pMa;
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

        public bool Sua(DocGia pDocGia, string idx)
        {
            try
            {
                string sql = string.Format("UPDATE DocGia " +
                "SET HoTenDocGia = '{0}', NgaySinh = '{1}', DiaChi = '{2}', Email = '{3}', NgayLapThe = '{4}', NgayHetHan = '{5}', TienNo = '{6}' " +
                "WHERE MaDocGia = " + idx,
                pDocGia.HoTenDocGia, pDocGia.NgaySinh,
                pDocGia.DiaChi, pDocGia.Email, pDocGia.NgayLapThe, pDocGia.NgayHetHan, pDocGia.TienNo);
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
        public int Get_MaDocGia(string pHoTenDocGia)
        {
            _sqlConn.Open();
            string sqlDocGia = "select MaDocGia from DocGia where HoTenDocGia = N'" + pHoTenDocGia +"'";
            SqlCommand cmdBC = new SqlCommand(sqlDocGia, _sqlConn);
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

            for (int i = 0; i < arrBC.Count; i++)
                if (pHoTenDocGia == arrBC[i].ToString())
                    return i + 1;
            return Int32.Parse(arrBC[0].ToString());
        }
        public string Get_TenDocGia(string pMa)
        {
            _sqlConn.Open();
            string sqlDocGia = "select HoTenDocGia from DocGia where MaDocGia = " + pMa;
            SqlCommand cmdBC = new SqlCommand(sqlDocGia, _sqlConn);
            SqlDataReader rdBC;
            rdBC = cmdBC.ExecuteReader();
            ArrayList arrBC = new ArrayList(); //chứa tên(string) các loại bằng cấp
            while (rdBC.Read())
            {
                arrBC.Add(rdBC.GetString(0).ToString());
            }
            rdBC.Close();
            cmdBC.Dispose();
            _sqlConn.Close();

            return arrBC[0].ToString();
        }
    }
}
