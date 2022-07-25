using System;

public class Title
{
	public string TitleBook { set; get; }
	public void Show()
    {
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.WriteLine($"Title book: {TitleBook}");
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine(new string('*', 15));
	}
	public Title()
	{
	}
}
