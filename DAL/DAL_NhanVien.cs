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
    public class DAL_NhanVien : DBConnect
    {

        public DataTable Get_NhanVien()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", _sqlConn);
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

        //public DAL_NhanVien()
        //{
        //    dt = Get_NhanVien();
        //    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}

        //DataTable dt = new DataTable();
        //public DataTable Get()
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", _sqlConn);
        //        DataSet ds = new DataSet();
        //        //DataTable ds = new DataTable();
        //        da.Fill(ds);
        //        return ds.Tables[0];
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}


        public bool Them(NhanVien pNhanVien)
        {
            try
            {
                string sql = string.Format("INSERT INTO NhanVien "
                + "VALUES (N'{0}','{1}',N'{2}','{3}','{4}')",
                pNhanVien.HoTenNhanVien, pNhanVien.NgaySinh,
                pNhanVien.DiaChi, pNhanVien.DienThoai, pNhanVien.MaBangCap);
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


        //public bool Them(NhanVien pNhanVien)
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", _sqlConn);
        //        DataRow r = dt.NewRow();
        //        r["HoTenNhanVien"] = pNhanVien.HoTenNhanVien;
        //        r["NgaySinh"] = pNhanVien.NgaySinh;
        //        r["DiaChi"] = pNhanVien.DiaChi;
        //        r["DienThoai"] = pNhanVien.DienThoai;
        //        r["MaBangCap"] = pNhanVien.MaBangCap;

        //        dt.Rows.Add(r);

        //        SqlCommandBuilder cm = new SqlCommandBuilder(da);
        //        da.Update(dt);

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public bool Xoa(string pMa)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = " + pMa;
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

        public bool Sua(NhanVien pNhanVien, string idx)
        {
            try
            {
                string sql = string.Format("UPDATE NhanVien " +
                "SET HoTenNhanVien = '{0}', NgaySinh = '{1}', DiaChi = '{2}', DienThoai = '{3}', MaBangCap = '{4}' " +
                "WHERE MaNhanVien = " + idx,
                pNhanVien.HoTenNhanVien, pNhanVien.NgaySinh,
                pNhanVien.DiaChi, pNhanVien.DienThoai, pNhanVien.MaBangCap);
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
