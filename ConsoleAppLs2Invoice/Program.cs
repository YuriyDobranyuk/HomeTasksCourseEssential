using System;
/*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider, которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.*/
namespace ConsoleAppLs2Invoice
{
    class Program
    {
        static int EnterPrice()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter price, please:");
            int.TryParse(Console.ReadLine(), out var price);
            if (price == 0) price = EnterPrice();
            return price;
        }
        static string EnterNamePayer()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter name payer, please:");
            var name = Console.ReadLine();
            if (name == "") name = EnterNamePayer();
            return name;
        }
        static string EnterNameSaler()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter name saler, please:");
            var name = Console.ReadLine();
            if (name == "") name = EnterNameSaler();
            return name;
        }
        static string EnterArticle()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter article, please:");
            var value = Console.ReadLine();
            if (value == "") value = EnterArticle();
            return value;
        }
        static int EnterQuantity()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter quantity, please:");
            int.TryParse(Console.ReadLine(), out var value);
            if (value == 0) value = EnterQuantity();
            return value;
        }
        static void Main(string[] args)
        {
            Invoice currentInvoice = new Invoice(EnterPrice(), EnterNamePayer(), EnterNameSaler())
            {
                Article = EnterArticle(),
                Quantity = EnterQuantity(),
            };
            currentInvoice.Calculate();
            currentInvoice.Show();
            Console.ReadKey();
        }
    }
}
