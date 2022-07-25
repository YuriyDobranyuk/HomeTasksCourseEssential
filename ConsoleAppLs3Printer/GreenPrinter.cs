using System;

namespace ConsoleAppLs3Printer
{
    class GreenPrinter : RedPrinter
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new String('*', 20));
            Console.WriteLine(value);
            Console.WriteLine(new String('*', 20));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
