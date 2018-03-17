using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            moto.PopAWheely();
            Method( moto);
        }
        static void Method( Motorcycle mot)
        {
            mot.Name = "Jeffry";
            Console.WriteLine("{0}   {1}", mot.Name, mot.Speed);

            mot = new Motorcycle(Speed:12);
            Console.WriteLine("{0}   {1}", mot.Name, mot.Speed);
        }
    }
}
