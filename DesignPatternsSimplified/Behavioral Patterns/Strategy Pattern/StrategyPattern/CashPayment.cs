using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashPayment : IPayment
    {
        string address;
        string name;
        public CashPayment(string address, string name)
        {
            this.address = address;
            this.name = name;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("********************CashPayment********************************");

            Console.WriteLine("{0} will be collected on delivery at address {1}", amount, this.address);
        }
    }
}
