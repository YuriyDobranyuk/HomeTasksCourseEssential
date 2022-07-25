using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLs3DocumentWorker
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
