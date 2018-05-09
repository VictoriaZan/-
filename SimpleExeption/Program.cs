using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Exemple*****");
            Console.WriteLine("Creating a car!!!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message {0}",ex.Message);
                Console.WriteLine("Target Site {0}, Declaryng Type {1}, Member Type {2}", ex.TargetSite, ex.TargetSite.DeclaringType, ex.TargetSite.MemberType);
                Console.WriteLine("Source {0}", ex.Source);
                Console.WriteLine("Stack Trace {0}", ex.StackTrace);
                Console.WriteLine("Help Link {0}", ex.HelpLink);
                if(ex. Data != null)
                {
                    foreach (DictionaryEntry e in ex.Data)
                        Console.WriteLine("Key {0}, data: {1}", e.Key, e.Value);
                }
            }
        }
    }
}
