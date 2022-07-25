using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLs3ClassRoom
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("I am excelent pupil.");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("I can excelent read.");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("I write excelent.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("I very bad relax, because I excelent pupil.");
        }
    }
}
