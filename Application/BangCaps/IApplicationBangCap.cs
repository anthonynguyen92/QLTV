using System.Data;

namespace Application.BangCaps
{
    public interface IApplicationBangCap
    {
        DataTable Get_BangCap();
        string Get_MaBangCap(string pTenBangCap);
    }
}
