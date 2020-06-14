using Application.BangCaps;
using System.Data;

namespace BUS.BangCapService
{
    public class BUS_BangCap : IBUS_BangCap
    {
        private readonly IApplicationBangCap _application;
        
        public BUS_BangCap(IApplicationBangCap application)
        {
            _application = application;
        }
        
        public DataTable Get_BangCap()
        {
            return _application.Get_BangCap();
        }
        
        public string Get_MaBangCap(string pTenBangCap)
        {
            return _application.Get_MaBangCap(pTenBangCap);
        }
    }
}
