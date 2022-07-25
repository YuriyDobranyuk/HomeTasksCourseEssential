using System;
using System.Collections.Generic;
/*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.*/
namespace ConsoleAppFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            static int SetCountPoint()
            {
                Console.WriteLine("Enter count point for figure (3 or 4 or 5):");
                int.TryParse(Console.ReadLine(), out var countPoint);
                if (countPoint == 0 || (countPoint != 3 && countPoint != 4 && countPoint != 5)) countPoint = SetCountPoint();
                return countPoint;
            }
            int countPointForFigure = SetCountPoint();
            static string SetNamePoint()
            {
                Console.WriteLine("Enter name point:");
                return Console.ReadLine();
            }
            static int SetCoord1()
            {
                Console.WriteLine("Enter first coordinate point:");
                int.TryParse(Console.ReadLine(), out var coord_x);
                if (coord_x == 0) coord_x = SetCoord1();
                return coord_x;
            }
            static int SetCoord2()
            {
                Console.WriteLine("Enter secound coordinate point:");
                int.TryParse(Console.ReadLine(), out var coord_y);
                if (coord_y == 0) coord_y = SetCoord2();
                return coord_y;
            }
            List<Point> Points = new List<Point>();
            for (int i = 1; i <= countPointForFigure; i++)
            {
                var newPoint = new Point(SetNamePoint(), SetCoord1(), SetCoord2());
                Points.Add(newPoint);
            }
            new Figure(Points);

            Console.ReadKey();
        }
    }
}
