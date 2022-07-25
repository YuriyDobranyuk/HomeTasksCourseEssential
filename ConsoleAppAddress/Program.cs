using System;
/*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс с именем Address.
В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого
поля, создать свойство с двумя методами доступа.
Создать экземпляр класса Address.
В поля экземпляра записать информацию о почтовом адресе.
Выведите на экран значения полей, описывающих адрес.*/
namespace ConsoleAppAddress
{
    class Program
    {
        static void Main()
        {
            Address myAddress = new Address();
            myAddress.Index = "21029";
            myAddress.Country = "Ukraine";
            myAddress.City = "Vinnitsya";
            myAddress.Street = "Keletska";
            myAddress.House = "132a";
            myAddress.Apartment = "113";
            myAddress.Show();
           
        }
    }
}
