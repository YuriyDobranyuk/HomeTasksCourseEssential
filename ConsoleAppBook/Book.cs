using System;

namespace ConsoleAppBook
{
	public class Book
	{
		Title title = null;
		Author author = null;
		Content content = null;
		private void InitializeBook()
        {
			this.title = new Title();
			this.author = new Author();
			this.content = new Content();
		}
		public string Title {
            set
            {
				this.title.TitleBook = value;
			} 
		}
		public string Author
		{
			set
			{
				this.author.AuthorBook = value;
			}
		}
		public string Content
		{
			set
			{
				this.content.ContentBook = value;
			}
		}
		public void Show()
		{
			this.title.Show();
			this.author.Show();
			this.content.Show();
			Console.WriteLine(new string('-', 30));
		}
		public Book()
		{
			InitializeBook();
		}
	}
}

