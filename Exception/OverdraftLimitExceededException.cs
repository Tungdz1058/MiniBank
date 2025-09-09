using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Exception
{
    public class OverdraftLimitExceededException : ApplicationException
    {
        public OverdraftLimitExceededException(string mess) : base(mess) { }
    }
}
