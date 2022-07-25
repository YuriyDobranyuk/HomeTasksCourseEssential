using System;

namespace ConsoleAppLs3Vehicle
{
    class Ship : Vehicle
    {
        private readonly string port;
        protected int passengerNumbers;
        private string v;

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"PassengerNumbers: {passengerNumbers}.");
            if(!string.IsNullOrEmpty(port)) Console.WriteLine($"Home port: {port}.");
        }
        public Ship() { }
        public Ship(string name, int price, int year, int speed, int passengerNumbers, string port) : base(name, price, year, speed)
        {
            this.passengerNumbers = passengerNumbers;
            this.port = port;
        } 
    }
}
