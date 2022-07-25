using System;

namespace ConsoleAppLs3Vehicle
{
    class Vehicle
    {
        protected int price, speed, releaseYear;
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine(new String('-', 10));
            Console.WriteLine($"Name vehicle: {Name}.");
            Console.WriteLine($"Price: {price}.");
            Console.WriteLine($"Speed: {speed}.");
            Console.WriteLine($"Release year: {releaseYear}");
        }
        public Vehicle() { }
        public Vehicle(string name, int price, int year, int speed)
        {
            this.Name = name;
            this.price = price;
            this.releaseYear = year;
            this.speed = speed;
        }
    }
}
