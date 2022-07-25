using System;

namespace ConsoleAppLs3ClassRoom
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("I am good pupil.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I can good read.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I can good write.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I can bad relax, because I good pupil.");
        }
    }
}
