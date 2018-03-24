using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PayPalPayment : IPayment
    {
        private string email;
        private string password;
        public PayPalPayment(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("********************PayPalPayment******************************");
            Console.WriteLine("{0} is deducted from Paypal Account {1}", amount, this.email);
        }
    }
}
