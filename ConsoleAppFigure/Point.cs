using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFigure
{
    class Point
    {
        private string pointName;
        private int x, y;
        public string PointName
        {
            get
            {
                return pointName;
            }
        }
        public int X {
            get
            {
                return x;
            }
        }
        public int Y {
            get 
            {
                return y;
            } 
        }
        public Point(string name, int coord_x, int coord_y)
        {
            pointName = name;
            x = coord_x;
            y = coord_y;
        }
    }
}
