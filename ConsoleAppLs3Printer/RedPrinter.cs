using System;

namespace ConsoleAppLs3Printer
{
    class RedPrinter : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new String('*', 20));
            Console.WriteLine(value);
            Console.WriteLine(new String('*', 20));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
