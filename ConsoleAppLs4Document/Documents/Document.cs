using ConsoleAppLs4Document.Documents.Parts;

namespace ConsoleAppLs4Document.Documents
{
    class Document
    {
        Title title;
        Body body;
        Footer footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }
    }
}
