using System;
/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.*/
namespace ConsoleAppLs2Converter
{
    class Program
    {
        static double SetCourseUsd()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter your course for USD by UAH, please:");
            double.TryParse(Console.ReadLine(), out double courseUSD);
            if (courseUSD == 0) courseUSD = SetCourseUsd();
            return courseUSD;
        }
        static double SetCourseEur()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter your course for EUR by UAH, please:");
            double.TryParse(Console.ReadLine(), out double courseEUR);
            if (courseEUR == 0) courseEUR = SetCourseEur();
            return courseEUR;
        }
        static double SetCourseRub()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter your course for RUB by UAH, please:");
            double.TryParse(Console.ReadLine(), out var courseRUB);
            if (courseRUB == 0) courseRUB = SetCourseRub();
            return courseRUB;
        }
        static string SetEnterUserToWorkApp()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("For continue work app, enter \"1\". For exit app enter other number or symbol.");
            Console.WriteLine(new String('*', 20));
            return Console.ReadLine();
        }
        static string ChooseTypeOperation()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Choose type operation:");
            Console.WriteLine("For currenty purcase, enter \"1\"");
            Console.WriteLine("For currensy sale, enter \"2\"");
            var result = Console.ReadLine();
            if (result != "1" && result != "2") result = ChooseTypeOperation();
            return result;
        }
        static string ChooseTypeCurrency()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Choose type currency:");
            Console.WriteLine("For currenty USD, enter \"1\"");
            Console.WriteLine("For currensy EUR, enter \"2\"");
            Console.WriteLine("For currensy RUB, enter \"3\"");
            var result = Console.ReadLine();
            if (result != "1" && result != "2" && result != "3") result = ChooseTypeCurrency();
            return result;
        }
        static double SetCountCurrency()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter count currency, please:");
            double.TryParse(Console.ReadLine(), out var value);
            if (value == 0) value = SetCountCurrency();
            return value;
        }
        static void Main(string[] args)
        {
            Converter currentConverter = new Converter(SetCourseUsd(), SetCourseEur(), SetCourseRub());
            string enterUser = "1";
            while (enterUser == "1")
            {
                var typeOperation = ChooseTypeOperation();
                var typeCurrency = ChooseTypeCurrency();
                var currencyCount = SetCountCurrency();
                currentConverter.IndexTypeOperation = typeOperation;
                currentConverter.IndexTypeCurrency = typeCurrency;
                currentConverter.CurrencyCount = currencyCount;
                currentConverter.ConvertCurrency();
                currentConverter.Show();
                enterUser = SetEnterUserToWorkApp();
            }
        }

        
    }
}
