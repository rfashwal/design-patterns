using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Item> items = new List<Item>();
                items.Add(new Item("External HDD", 60));
                items.Add(new Item("Kids Toy", 20));
                items.Add(new Item("Candles", 5));



                Console.WriteLine("Enter payment Type: (C) Cash, (CC) Credit Card, (P) Paypal");

                string inputPayment = Console.ReadLine();

                IPayment paymentMethod = null;

                switch (inputPayment.ToLower())
                {
                    case "p":
                        paymentMethod = new PayPalPayment("mike@mike.com", "123456");
                        break;
                    case "cc":
                        paymentMethod = new CreditCardPayment("Adam", "1111222233334444", "123", "3112");
                        break;
                    case "c":
                        paymentMethod = new CashPayment("USA, Ohaio", "John");
                        break;
                    default:

                        break;
                }
                ShoppingCart cart = new ShoppingCart(paymentMethod)
                {
                    Items = items
                };
                cart.CalculateOrderAndPay();

            }
        }
    }
}
