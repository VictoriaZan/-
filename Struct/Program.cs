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
            /* Point point;
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
             p2.Display();*/

            /* Point p1 = new Point(10, 20);
             Point p2 = p1;
             p1.Display();
             p2.Display();
             p1.Increment();
             p2.Decrement();
             p1.Display();
             p2.Display();
             //--------------------------------
             PointRef pr1 = new PointRef(22, 44);
             PointRef pr2 = pr1;
             pr2.x = 77;
             pr1.Display();
             pr2.Display();*/
            int? a = 100;
            a = null;
            char? c = null;

            DataBaseReader dr = new DataBaseReader();

            int? i = dr.GetInt()?? 100;
            if(i.HasValue)
                Console.WriteLine("Value of i is {0}",i.Value);
            else
                Console.WriteLine("i is undefined");
            bool? b = dr.GetBool();
            if(b!=null)
                Console.WriteLine("value of b is {0}", b.Value);
            else
                Console.WriteLine("b is undefined");
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

    class PointRef
    {
        public int x;
        public int y;

        public PointRef(int XPos, int YPos)
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
            x--; y--;
        }
        public void Display()
        {
            Console.WriteLine("X={0}, Y={1},", x, y);
        }
    }
    class DataBaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetInt()
        { return numericValue; }
        public bool? GetBool()
        { return boolValue; }
            
     }
}
