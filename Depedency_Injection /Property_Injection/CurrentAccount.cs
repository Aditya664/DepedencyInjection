using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection .Property_Injection
{
    public class CurrentAccount : IAccount
    {
        public void PrintDetails(){
            Console.WriteLine("Details of Saving account");
        }
    }
}