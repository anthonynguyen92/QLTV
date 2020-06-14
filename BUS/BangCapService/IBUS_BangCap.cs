using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BangCapService
{
    public interface IBUS_BangCap
    {
        DataTable Get_BangCap();
        string Get_MaBangCap(string pTenBangCap);
    }
}
