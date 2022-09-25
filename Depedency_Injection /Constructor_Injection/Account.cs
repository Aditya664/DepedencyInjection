using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection.Constructor_Injection
{
    public class Account
    {

        private IAccount _account;
        public Account(IAccount account)
        { // Parameterized Constructor
            this._account = account;
        }

        public void PrintAccount()
        {
            _account.PrintDetails();
        }
        // static void Main()
        // {
        //     IAccount ca = new CurrentAccount();
        //     IAccount sa = new SavingAccount();
        //     Account account1 = new Account(ca);
        //     Account account2 = new Account(ca);
        //     account1.PrintAccount();
        //     account2.PrintAccount();
        // }
    }
}