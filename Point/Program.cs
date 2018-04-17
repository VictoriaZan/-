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
            Point p2 = new Point { X = 10, Y = 20 };
            p1.DisplayStats();
            p2.DisplayStats();
        }
    }
    class Point
    {
        private int valueX;
        private int valueY;
        public int X { get; set; }
        public int Y { get; set; }
        public void DisplayStats()
        {
            Console.WriteLine("{0}, {1}", X,Y);
        }
        public Point() { }
    }
}
