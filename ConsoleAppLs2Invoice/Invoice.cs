using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLs2Invoice
{
    class Invoice
    {
        readonly public int account;
        readonly public string customer, provider;
        private string article;
        private int quantity;
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Payment { get; set; }
        const double VAT_PERCENT = 0.2;
        public double Vat { get; set; }
        public double PaymentWithoutVAT { get; set; }
        public void Calculate()
        {
            Payment = account * quantity;
            Vat = Payment * VAT_PERCENT;
            PaymentWithoutVAT = Payment - Vat;
        }
        public void Show()
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Current invoice:");
            Console.WriteLine($"Payer {customer} bye in {provider} product {Article} " +
                $"in count {Quantity} by price {account} UAH.");
            Console.WriteLine($"All sum to pay: {Payment}");
            Console.WriteLine($"All vat with payment: {Vat}");
            Console.WriteLine($"All sum to pay without vat: {PaymentWithoutVAT}");
            Console.WriteLine(new String('*', 20));
        }
        public Invoice() { }
        public Invoice( int price, string namePayer, string nameSaler ) 
        {
            account = price;
            customer = namePayer;
            provider = nameSaler;
        }  
    }
}
