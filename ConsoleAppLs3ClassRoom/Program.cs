using System;
/*Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс, представляющий учебный класс ClassRoom.
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
писать, отдыхать.
 */
namespace ConsoleAppLs3ClassRoom
{
    class Program
    {
        static int EnterCountPupilsAddOnFirst()
        {
            Console.WriteLine("Enter number pupil you want add in create class:");
            Console.WriteLine("1 - for one pupil.");
            Console.WriteLine("2 - for two pupil.");
            Console.WriteLine("3 - for three pupil.");
            int.TryParse(Console.ReadLine(), out var value);
            if (value == 0 || (value != 1 && value != 2 && value != 3)) value = EnterCountPupilsAddOnFirst();
            return value;
        }
        static string EnterNamePupil()
        {
            Console.WriteLine("Enter name pupil:");
            string name = Console.ReadLine();
            if (name == "") name = EnterNamePupil();
            return name;
        }
        static int EnterKindPupil()
        {
            Console.WriteLine("Enter kind pupil:");
            Console.WriteLine("1 - for excelent pupil.");
            Console.WriteLine("2 - for good pupil.");
            Console.WriteLine("3 - for bad pupil.");
            int.TryParse(Console.ReadLine(), out var value);
            if (value == 0 || (value != 1 && value != 2 && value != 3)) value = EnterKindPupil();
            return value;
        }
        static Pupil FormingInstancePupil()
        {
            string name = EnterNamePupil();
            int kind = EnterKindPupil();
            Pupil newInstancePupil = null;
            if (kind == 1)
            {
                ExcelentPupil instancePupil = new ExcelentPupil();
                instancePupil.Name = name;
                newInstancePupil = instancePupil;
            }
            else if (kind == 2)
            {
                GoodPupil instancePupil = new GoodPupil();
                instancePupil.Name = name;
                newInstancePupil = instancePupil;
            }
            else if (kind == 3)
            {
                BadPupil instancePupil = new BadPupil();
                instancePupil.Name = name;
                newInstancePupil = instancePupil;
            }
            return newInstancePupil;
        }
        static void Main(string[] args)
        {
            int count = EnterCountPupilsAddOnFirst();
            ClassRoom ourClassRoom = null;
            if (count == 1)
            {
                ourClassRoom = new ClassRoom(FormingInstancePupil());
                for (var i = 1; i <= 3; i++)
                {
                    ourClassRoom.AddElement(FormingInstancePupil());
                }
            }
            else if (count == 2)
            {
                ourClassRoom = new ClassRoom(FormingInstancePupil(), FormingInstancePupil());
                for (var i = 1; i <= 2; i++)
                {
                    ourClassRoom.AddElement(FormingInstancePupil());
                }
            }
            else if (count == 3)
            {
                ourClassRoom = new ClassRoom(FormingInstancePupil(), FormingInstancePupil(), FormingInstancePupil());
                ourClassRoom.AddElement(FormingInstancePupil());
            }
            ourClassRoom.Show();
        }
    }
}
