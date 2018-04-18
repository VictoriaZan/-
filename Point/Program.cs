using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point() { X = 10, Y = 20 };
            p1.DisplayStats();
            p2.DisplayStats();
            Point p3 = new Point(PointColor.LightBlue) { X = 20, Y = 90 };
            p3.DisplayStats();

            Rectangle r = new Rectangle
            {
                TopLeft = new Point (PointColor.BloodRed){ X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            r.DisplayStats();
        }
    }
    public enum PointColor { Gold, LightBlue, BloodRed}
    class Point
    {
        private int valueX;
        private int valueY;
        private PointColor pc; 
        public PointColor Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void DisplayStats()
        {
            Console.WriteLine("{0}, {1}, {2}", X,Y,Color);
        }
        public Point() { }
        public Point(int xp, int yp)
        {
            X = xp;
            Y = yp;
            Color = PointColor.BloodRed;
        }
        public Point(PointColor c)
        {
            Color = c;
        }
    }
}
