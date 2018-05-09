using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomException
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
            catch (CarIsDeadException ex)
            {
                Console.WriteLine("Message {0}, Time {1}, Cause {2}", ex.Message, ex.ErrorTimeStamp, ex.CauseOfError);
                
            }
        }
    }
}
