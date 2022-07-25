using System;
/*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
версии Про".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
форматах доступно в версии Эксперт".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
"Документ сохранен в новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.*/
namespace ConsoleAppLs3DocumentWorker
{
    class Program
    {
        public static string EnterKeyAccess()
        {
            Console.WriteLine("Enter key access, please (pro or exp):");
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 5)
            {
                string keyFromUser = EnterKeyAccess();
                DocumentWorker instanceDW = null;
                if (keyFromUser == "exp")
                {
                    ExpertDocumentWorker instanceEDW = new();
                    ProDocumentWorker instancePDW = instanceEDW;
                    instanceDW = instancePDW;
                }
                else if (keyFromUser == "pro")
                {
                    ProDocumentWorker instancePDW = new();
                    instanceDW = instancePDW;
                }
                else
                {
                    instanceDW = new();
                }
                Console.WriteLine(new String('*', 20));
                instanceDW.OpenDocument();
                instanceDW.EditDocument();
                instanceDW.SaveDocument();
                Console.WriteLine(new String('*', 20));
                i++;
            }
            Console.ReadKey();
        }
    }
}
