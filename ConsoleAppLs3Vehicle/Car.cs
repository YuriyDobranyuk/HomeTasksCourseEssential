using System;

namespace ConsoleAppLs3Vehicle
{
    class Car : Vehicle
    {
        private string color;
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Color: {color}.");
        }
        public Car() { }
        public Car(string name, int price, int year, int speed, string color) : base(name, price, year, speed)
        {
            this.color = color;
        }
    }
}
