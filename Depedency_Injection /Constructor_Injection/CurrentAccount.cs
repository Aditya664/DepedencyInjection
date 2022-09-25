using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepedencyInjection.Depedency_Injection.Constructor_Injection
{
    public class CurrentAccount : IAccount
    {
        public void PrintDetails(){
            Console.WriteLine("Details of Current account");
        }
    }
}