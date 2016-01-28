using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetiaPaymentModuleBradesco
{
    class PagamentoBradescoException : Exception
    {
        public PagamentoBradescoException() { }

        public PagamentoBradescoException(String message) : base(message) { }

        public PagamentoBradescoException(String message, Exception exp) : base(message, exp) { }
    }
}
