using System;

namespace ConsoleAppLs4Document.Documents.Parts
{
    class Footer : PartDocument
    {
        public override string Content { 
            get
            {
                if (content == null)
                    return "Нижний колонтитул отсуствует.";
                else
                    return content;
            }
            set
            {
                content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
