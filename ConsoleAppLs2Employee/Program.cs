using System;
/*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Employee.
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
инициализирует поля, соответствующие фамилии и имени сотрудника.
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
сбор.
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
оклад и налоговый сбор.*/
namespace ConsoleAppLs2Employee
{
    class Program
    {
        static string EnterSurnameEmployee()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter surname your employee, please:");
            string value = Console.ReadLine();
            if (value == "") value = EnterSurnameEmployee();
            return value;
        }
        static string EnterNameEmployee()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter name your employee, please:");
            string value = Console.ReadLine();
            if (value == "") value = EnterNameEmployee();
            return value;
        }
        static string EnterJobPositionEmployee()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter job position your employee " +
                "(example: director, head of department, manager, worker or your variant), please:");
            string value = Console.ReadLine();
            if (value == "") value = EnterJobPositionEmployee();
            return value;
        }
        static double EnterSeniorityEmployee()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter seniority your employee, please:");
            double.TryParse(Console.ReadLine(), out var value);
            if (value == 0) value = EnterSeniorityEmployee();
            return value;
        }
        static int EnterCountEmployees()
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Enter count your employees, please:");
            int.TryParse(Console.ReadLine(), out var value);
            if (value == 0) value = EnterCountEmployees();
            return value;
        }
        static Employees currentListEmployees = new Employees();
        static void AddEmployeeToList(int count)
        {
            for (var i = 1; i <= count; i++)
            {
                Employee currentEmployee = new Employee(EnterSurnameEmployee(), EnterNameEmployee()) 
                { 
                    JobPosition = EnterJobPositionEmployee(),
                    Seniority = EnterSeniorityEmployee()
                };
                currentEmployee.CalculateTax();
                currentListEmployees.ListEmployees.Add(currentEmployee);
            }
        }
        static void Show()
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("My employees in companny:");
            foreach (var val in currentListEmployees.ListEmployees)
            {
                Console.WriteLine($"Surname: {val.surname}.");
                Console.WriteLine($"Name: {val.name}.");
                Console.WriteLine($"Job position: {val.JobPosition}.");
                Console.WriteLine($"Seniority: {val.Seniority}.");
                Console.WriteLine($"Wage: {val.Wage}.");
                Console.WriteLine($"Tax: {val.Tax}.");
                Console.WriteLine(new String('/', 15));
            }
            Console.WriteLine(new String('*', 20));
        }
        static void Main(string[] args)
        {
            int countemployees = EnterCountEmployees();
            AddEmployeeToList(countemployees);
            Show();
        }
    }
}
