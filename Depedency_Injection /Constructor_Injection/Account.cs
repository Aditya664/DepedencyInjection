using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection.Constructor_Injection
{
    public class Account
    {
        CurrentAccount CurrentAccount = new CurrentAccount();
        SavingAccount savingAccount = new SavingAccount();  

        public void PrintAccount(){
            CurrentAccount.PrintDetails();
            savingAccount.PrintDetails();
        }

        static void Main(){
            Account account = new Account();
            account.PrintAccount();
        }
    }
}