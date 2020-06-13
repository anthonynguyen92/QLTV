using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _sqlConn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");
    }
}
