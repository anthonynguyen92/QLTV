using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using DTO;

namespace DAL
{
    public class DAL_BangCap : DBConnect
    {
        public DataTable Get_BangCap()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BangCap", _sqlConn);
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
        public int Get_MaBangCap(string pTenBangCap)
        {
            _sqlConn.Open();
            string sqlBANGCAP = "select * from BangCap";
            SqlCommand cmdBC = new SqlCommand(sqlBANGCAP, _sqlConn);
            SqlDataReader rdBC;
            rdBC = cmdBC.ExecuteReader();
            ArrayList arrBC = new ArrayList(); //chứa tên(string) các loại bằng cấp
            while (rdBC.Read())
            {
                arrBC.Add(rdBC.GetString(1).ToString());
            }
            rdBC.Close();
            cmdBC.Dispose();
            _sqlConn.Close();

            for (int i = 0; i < arrBC.Count; i++)
                if (pTenBangCap == arrBC[i].ToString())
                    return i + 1;
            return -1;
        }
    }
}
