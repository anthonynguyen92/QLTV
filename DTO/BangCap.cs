using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangCap
    {
        private string _MaBangCap;

        public string MaBangCap
        {
            get { return _MaBangCap; }
            set { _MaBangCap = value; }
        }

        private string _TenBangCap;

        public string TenBangCap
        {
            get { return _TenBangCap; }
            set { _TenBangCap = value; }
        }

        public BangCap(string pMaBangCap, string pTenBangCap)
        {
            this._MaBangCap = pMaBangCap;
            this._TenBangCap = pTenBangCap;
        }

    }
}
