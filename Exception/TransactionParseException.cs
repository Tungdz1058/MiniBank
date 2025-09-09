using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Exception
{
    public class TransactionParseException : ApplicationException
    {
        public TransactionParseException(string mess) : base(mess) { }
    }
}
