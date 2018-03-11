using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumType emp = EnumType.Contractor;
            AskForBonus(emp);
            Console.WriteLine("UnderLyingType is {0}", System.Enum.GetUnderlyingType(emp.GetType()));

            Console.WriteLine("UnderLyingType is {0}", System.Enum.GetUnderlyingType(typeof(EnumType)));
            Console.WriteLine("This is a {0}, and this value is {1}", emp.ToString(),(byte)emp);

            Array datas = System.Enum.GetValues(typeof(EnumType));
            foreach(var d in datas)
                Console.WriteLine("Name: {0}, Value {0:D}\n",d);

            Worker w1 = new Worker();
            w1.name = "Julic";
            w1.age = 33;
            w1.work = EnumType.VicePrecident;

            Console.WriteLine("About worker: {0}, {1}, {2}, {2:D}", w1.name, w1.age, w1.work);
        }
        enum EnumType:byte
        {
            Manager = 102,
            Grunt,
            Contractor = 12,
            VicePrecident
        }
        static void AskForBonus(EnumType e)
        {
            switch (e)
            {
                case EnumType.Contractor:
                    Console.WriteLine( "contractor has enough cash");
                    break;
                case EnumType.Manager:
                    Console.WriteLine("Good benefits!");
                    break;
                case EnumType.VicePrecident:
                    Console.WriteLine("Wow!");
                    break;
                case EnumType.Grunt:
                    Console.WriteLine("Grunt...");
                    break;
            }
        }
        class Worker
        {
           public string name;
          public  int age;
          public  EnumType work;
        }
    }
}
