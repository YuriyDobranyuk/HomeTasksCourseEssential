using System;
using System.Collections.Generic;

namespace ConsoleAppLs3ClassRoom
{
    class ClassRoom
    {
        private List<Pupil> MembersClass = new List<Pupil>();
        public void AddElement(Pupil pupil)
        {
            MembersClass.Add(pupil);
        }
        public void Show()
        {
            Console.WriteLine(new String('*', 20));
            foreach (var value in MembersClass)
            {
                Console.WriteLine("It's pupil in our classes.");
                Console.WriteLine($"Name pupil: {value.Name}.");
                value.Study();
                value.Read();
                value.Write();
                value.Relax();
                Console.WriteLine(new String('-', 5));
            }
            Console.WriteLine(new String('*', 20));
        }
        public ClassRoom() { }
        public ClassRoom(Pupil pupilOne)
        {
            MembersClass.Add(pupilOne);
        }
        public ClassRoom(Pupil pupilOne, Pupil pupilSecound)
        {
            MembersClass.Add(pupilOne);
            MembersClass.Add(pupilSecound);
        }
        public ClassRoom(Pupil pupilOne, Pupil pupilSecound, Pupil pupilThird)
        {
            MembersClass.Add(pupilOne);
            MembersClass.Add(pupilSecound);
            MembersClass.Add(pupilThird);
        }
    }
}
