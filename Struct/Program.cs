using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.x = 349;
            point.y = 76;
            point.Display();
            point.Increment();
            point.Display();
            point.Decrement();
            point.Display();

            Point p1 = new Point();
            p1.Display();

            Point p2 = new Point(12, 22);
            p2.Display();
        }
        struct Point
        {
            public int x;
            public int y;

            public Point(int XPos, int YPos)
            {
                x = XPos;
                y = YPos;
            }
            public void Increment()
            {
                x++; y++;
            }
            public void Decrement()
            {
                x--;y--;
            }
            public void Display()
            {
                Console.WriteLine("X={0}, Y={1},", x,y);
            }
        }
    }
}
