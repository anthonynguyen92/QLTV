using EntityDb.EF;
using EntityDb.Entities;
using System.Data;
using System.Linq;

namespace Application.BangCaps
{
    public class ApplicationBangCap: IApplicationBangCap
    {
        private readonly QLDBContext _context;

        public ApplicationBangCap(QLDBContext context)
        {
            _context = context;
        }
        public DataTable Get_BangCap()
        {
            var getlist = from c in _context.BangCap
                          select c;

            return getlist.ToList().ToDataTable<BangCap>();
        }

        public string Get_MaBangCap(string pTenBangCap)
        {
            var getCode = from c in _context.BangCap
                          where c.TenBang.Contains(pTenBangCap)
                          select c.MaBang.ToString();
            return getCode.ToString();

        }
    }
}
