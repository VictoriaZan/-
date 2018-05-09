using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Homer","Simpson",50);
            Person p2 = new Person("Homer", "Simpson", 50);

            Console.WriteLine("To string: {0}", p1.ToString());
            Console.WriteLine("To string: {0}", p2.ToString());

            Console.WriteLine("p1 == p2?: {0}", p1.Equals(p2));

            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            p2.Age = 45;

            Console.WriteLine("To string: {0}", p1.ToString());
            Console.WriteLine("To string: {0}", p2.ToString());

            Console.WriteLine("p1 == p2?: {0}", p1.Equals(p2));

            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            p2.Age = 50;
            Console.WriteLine("o.eq {0}", object.Equals(p1,p2));
            Console.WriteLine("o.req {0}", object.ReferenceEquals(p1,p2));
        }
    }
}
