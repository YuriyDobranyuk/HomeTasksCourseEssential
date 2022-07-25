using System;
using System.Collections.Generic;
/* Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/
namespace ConsoleAppLs3Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new();
            vehicles.Add((Vehicle)new Car("Volvo", 5200, 1992, 195, "red"));
            vehicles.Add((Vehicle)new Ship("Sagaydachnyy", 195000, 1968, 130, 256, "Izmail"));
            vehicles.Add((Vehicle)new Plane("Mriya", 159365000, 1994, 320, 658, 3568));
            foreach (var value in vehicles)
            {
                value.Show();
            }
        }          
    } 
}

