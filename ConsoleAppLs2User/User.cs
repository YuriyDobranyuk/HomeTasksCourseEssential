using System;

namespace ConsoleAppLs2User
{
    class User
    {
        public readonly DateTime dateCreate;
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public void Show()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Data user:");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Date write: {dateCreate}");
            Console.WriteLine(new String('*', 20));
        }
        public User() {
            dateCreate = DateTime.Now;
        }
    }
}
