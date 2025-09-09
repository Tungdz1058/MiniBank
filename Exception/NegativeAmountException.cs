using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Exception
{
    public  class NegativeAmountException : ApplicationException
    {
        public NegativeAmountException(string mess) : base(mess) { }
    }
}
