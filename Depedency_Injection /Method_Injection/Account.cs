using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection.Method_Injection
{
    public class Account
    {
        public void PrintAccount(IAccount account){
            account.PrintDetails();
        }

        static void Main(){
            Account sa = new Account();
            sa.PrintAccount(new savingAccount());

             Account ca = new Account();
            ca.PrintAccount(new CurrentAccount());
            Console.ReadLine();
        }
    }
}