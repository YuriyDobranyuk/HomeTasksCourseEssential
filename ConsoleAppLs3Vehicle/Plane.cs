using System;

namespace ConsoleAppLs3Vehicle
{
    class Plane : Ship
    {
        private readonly int height;
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Height: {height}.");
        }
        public Plane() { }
        public Plane(string name, int price, int year, int speed, int passengerNumbers, int height) : base(name, price, year, speed, passengerNumbers, string.Empty)
        {
            this.height = height;
        }
    }
}
