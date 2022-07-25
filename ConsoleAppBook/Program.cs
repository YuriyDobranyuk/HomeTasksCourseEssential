using System;
/*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание.*/
namespace ConsoleAppBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book yourBook = new Book();

            Console.WriteLine("Enter title your book:");
            yourBook.Title = Console.ReadLine();
            Console.WriteLine("Enter author your book:");
            yourBook.Author = Console.ReadLine();
            Console.WriteLine("Enter content your book:");
            yourBook.Content = Console.ReadLine();
            yourBook.Show();

            Console.ReadKey();
        }
    }
}
