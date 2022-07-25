using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLs3ClassRoom
{
    class Pupil
    {
        public string Name { get; set; }
        public virtual void Study()
        {
            Console.WriteLine("I can study.");
        }
        public virtual void Read()
        {
            Console.WriteLine("I can ready.");
        }
        public virtual void Write()
        {
            Console.WriteLine("I can write.");
        }
        public virtual void Relax()
        {
            Console.WriteLine("I can relax.");
        }
    }
}
