using System;
/*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение
аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
выводились разными цветами.
Обязательно используйте приведение типов.*/
namespace ConsoleAppLs3Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer objPrinter = new Printer();
            objPrinter.Print("It is my text. He is white.");
            RedPrinter objRedPrinter = new RedPrinter();
            objRedPrinter.Print("It is my text. He is red.");
            GreenPrinter objGreenPrinter = new GreenPrinter();
            objGreenPrinter.Print("It is my text. He is green.");

            RedPrinter newRedObjGreenPrinter = (RedPrinter)objGreenPrinter;
            newRedObjGreenPrinter.Print("It is my text. He is not green, it is red. It is upcast.");
            Printer newWhiteObjGreenPrinter = (Printer)objGreenPrinter;
            newWhiteObjGreenPrinter.Print("It is my text. He is not green, it is white. It is upcast.");

            Printer newWhiteObjRedPrinter = (Printer)objRedPrinter;
            newWhiteObjRedPrinter.Print("It is my text. He is not red, it is white. It is upcast.");
            GreenPrinter newGreenObjGreenPrinter = (GreenPrinter)newRedObjGreenPrinter;
            newGreenObjGreenPrinter.Print("It is my text. He is not red, it is green. It is downcast.");

            RedPrinter newRedObjGreenPrinterDownCast = (RedPrinter)newWhiteObjGreenPrinter;
            newRedObjGreenPrinterDownCast.Print("It is my text. He is not white, it is red. It is downcast.");
            GreenPrinter newGreenObjGreenPrinterDownCast = (GreenPrinter)newRedObjGreenPrinter;
            newGreenObjGreenPrinterDownCast.Print("It is my text. He is not white, it is green. It is downcast.");

            Console.ReadKey();
        }
    }
}
