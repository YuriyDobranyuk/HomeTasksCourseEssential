using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAddress
{
    class Address
    {
        public string Index { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public string House { set; get; }
        public string Apartment { set; get; }

        public void Show() 
        {
            Console.WriteLine("My address: index - {0}; country - {1}; city - {2}; street - {3}; house - {4}; appartment - {5}", Index, Country, City, Street, House, Apartment);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"My address: {Street} street {House}, {Apartment}, {City}, {Country}, {Index}.");
            Console.WriteLine(new string('*', 50));
            Console.ReadKey();
        }
    }
}
