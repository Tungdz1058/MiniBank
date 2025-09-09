using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //test 
            List<BankAccount> minibank = new List<BankAccount>();
            BankManager a = new BankManager();
            a.AddNewBankAccount(minibank);
            a.find_account_number(minibank);
            a.AddNewBankAccount(minibank);
        }
    }
}
