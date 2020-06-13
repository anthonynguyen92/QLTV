using EntityDb.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using EntityDb.Entities;

namespace Application
{
    public class ApplicationBangCap
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
