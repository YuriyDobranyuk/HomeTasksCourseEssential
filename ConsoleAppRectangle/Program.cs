using System;
/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: Создать класс с именем Rectangle.
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь.*/
namespace ConsoleAppRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            static double SetSide1()
            {
                Console.WriteLine("Enter first size parameter rectangle:"); 
                double.TryParse(Console.ReadLine(), out var side1);
                if (side1 == 0) side1 = SetSide1();
                return side1;
            }
            static double SetSide2()
            {
                Console.WriteLine("Enter secound size parameter rectangle:");
                double.TryParse(Console.ReadLine(), out var side2);
                if (side2 == 0) side2 = SetSide2();
                return side2;
            }
            string enterUser = "1";
            while (enterUser == "1")
            {
                double userSide1 = SetSide1();
                double userSide2 = SetSide2();
                Rectangle userRectangle = new Rectangle(userSide1, userSide2);
                userRectangle.Show();
                enterUser = Console.ReadLine();
            }
            
        }
    }
}
