using System;
/*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.*/
namespace ConsoleAppLs2User
{
    class Program
    {
        static void Main(string[] args)
        {
            User currentUser = new User()
            {
                Login = "petrov25",
                Name = "Ivan",
                LastName = "Petrov",
                Age = 25
            };
            currentUser.Show();
        }
    }
}
