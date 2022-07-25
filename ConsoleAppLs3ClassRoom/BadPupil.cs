using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLs3ClassRoom
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("I bad study.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I can bad read.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I can bad write.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I can good relax, because I bad pupil.");
        }
    }
}
