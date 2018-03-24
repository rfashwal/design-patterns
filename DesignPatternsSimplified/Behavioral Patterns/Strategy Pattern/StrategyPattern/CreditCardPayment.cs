using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CreditCardPayment : IPayment
    {
        private string cardHolderName;
        private string cardNumber;
        private string cvv;
        private string expirayDate;

        public CreditCardPayment(string cardHolderName, string cardNumber, string cvv, string expirayDate)
        {
            this.cardHolderName = cardHolderName;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expirayDate = expirayDate;

        }
        public void Pay(decimal amount)
        {
            Console.WriteLine("***************************************************************"); 
            Console.WriteLine("********************CreditCardPayment**************************");
            Console.WriteLine(string.Format("{0} Paid {1} through Credit Card with Number {2}.", cardHolderName, amount, cardNumber));
        }
    }
}
