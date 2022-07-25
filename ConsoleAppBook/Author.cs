using System;

public class Author
{
	public string AuthorBook { set; get; }
	public void Show()
    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"Author book: {AuthorBook}");
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine(new string('*', 15));
	}
	public Author()
	{
	}
}
