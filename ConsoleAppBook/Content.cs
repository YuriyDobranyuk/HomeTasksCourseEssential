using System;

public class Content
{
	public string ContentBook { set; get; }
	public void Show()
    {
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine($"Content book: {ContentBook}");
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine(new string('*', 15));
	}
	public Content()
	{
	}
}
