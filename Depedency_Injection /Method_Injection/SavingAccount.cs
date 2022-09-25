using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection .Method_Injection
{
    public class savingAccount : IAccount
    {
         public void PrintDetails(){
            Console.WriteLine("Details of Saving account");
        }
    }
}