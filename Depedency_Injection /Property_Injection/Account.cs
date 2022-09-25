using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection .Property_Injection
{
    public class Account
    {
        public IAccount account {get;set;}
        public void PrintAccount(){
            account.PrintDetails();
        }

        // static void Main(){
            
        //     Account sa = new Account();
        //     sa.account = new SavingAccount();
        //     sa.PrintAccount();

        //     Account ca = new Account();
        //     ca.account = new CurrentAccount();
        //     ca.PrintAccount();

        //     Console.ReadLine();
        // }
    }
}