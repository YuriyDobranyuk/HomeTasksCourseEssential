using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFigure
{
    class Figure
    {
        public string NameFigure { get; set; }
        public double PerimeterFigure { get; set; }

        public double LengthSide(Point A, Point B)
        {
            double result = 0;
            double coord_x_AB = B.X - A.X;
            double coord_y_AB = B.Y - A.Y;
            result = Math.Sqrt(coord_x_AB * coord_x_AB + coord_y_AB * coord_y_AB);
            return result;
        }
        public void PerimeterCalculator(List<Point> Points)
        {
            int countPoints = Points.Count;
            for (int i = 0; i < countPoints; i++)
            {
                Point p1, p2;
                if (i == 0)
                {
                    p1 = Points[countPoints - 1];
                }
                else
                {
                    p1 = Points[i - 1];
                }
                p2 = Points[i];
                var lenSide = LengthSide(p1, p2);
                PerimeterFigure += lenSide;
            }
        }
        public void CreateNameFigure(List<Point> Points)
        {
            int countPoints = Points.Count;
            string name = "UnKnowFigure";
            if (countPoints == 3)
            {
                name = "Triangle";
            }
            else if (countPoints == 4)
            {
                name = "Quadrangle";
            }
            else if (countPoints == 5)
            {
                name = "Pentagon";
            }
            name += " ";
            foreach (var point in Points)
            {
                name += point.PointName;
            }
            NameFigure = name;
        }
        public void Show(List<Point> Points)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Points:");
            foreach (var point in Points)
            {
                Console.WriteLine($"{point.PointName}({point.X}, {point.Y}).");
            }
            Console.WriteLine($"Name figure: {NameFigure}.");
            Console.WriteLine($"Perimeter figure: {PerimeterFigure}.");
            Console.WriteLine(new string('*', 50));
            Console.ReadKey();
        }
        public Figure(List<Point> PointsList)
        {
            CreateNameFigure(PointsList);
            PerimeterCalculator(PointsList);
            Show(PointsList);
        }
        
    }
}
