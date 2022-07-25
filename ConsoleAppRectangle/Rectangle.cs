using System;

namespace ConsoleAppRectangle
{
	public class Rectangle
	{
        private readonly double side1;
        private readonly double side2;
        private double area;
        private double perimeter;

        public double Area
		{
			get
			{
				return this.area;
			}
		}
		public double Perimeter
		{
			get
			{
				return this.perimeter;
			}
		}
		private void CalculateArea()
		{
			var result = side1 * side2;
			this.area = result;
		}
		private void CalculatePerimeter()
		{
			var result = 2 * (side1 + side2);
			this.perimeter = result;
		}
		public void Show()
		{
			Console.WriteLine(new string('-', 50));
			Console.WriteLine($"Size rectangle: {side1} * {side2}.");
			Console.WriteLine($"Perimeter rectangle: {perimeter}.");
			Console.WriteLine($"Area rectangle: {area}.");
			Console.WriteLine(new string('*', 50));
			Console.ReadKey();
		}
		public Rectangle()
		{ }
		public Rectangle(double side1, double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
			this.CalculateArea();
			this.CalculatePerimeter();
		}
	}
}

