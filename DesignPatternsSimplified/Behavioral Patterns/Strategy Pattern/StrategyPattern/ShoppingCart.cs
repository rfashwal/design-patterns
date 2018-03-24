using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShoppingCart
    {
        IPayment paymentMethod;

        public List<Item> Items { get; set; }
        public ShoppingCart(IPayment paymentMethod)
        {
            if (paymentMethod == null)
                throw new NullReferenceException("paymentMethod");
            this.paymentMethod = paymentMethod;
        }
        public void CalculateOrderAndPay()
        {
            
            if (this.Items == null)
                throw new NullReferenceException("this.Items");
            decimal amount = this.Items.Sum(i => i.Price);
            this.paymentMethod.Pay(amount);
        }
    }
}
