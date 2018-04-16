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
            /*Motorcycle moto = new Motorcycle();
            moto.PopAWheely();
            Method( moto);*/
            //int aaa = vn();
            //Console.WriteLine(aaa);

            /*
            int[] arr = { 1, 0, 1 };
            string st = String.Join<int>("",arr);
            int a = Convert.ToInt32(st,2);
            Console.WriteLine(a);
            int x = 0;
            int o = 0;
            string sd = "xxOo";
            sd.ToLower();
            foreach (var s in sd)
            {
                if (s == 'x') x++;
                if (s == 'o') o++;
            }
            bool r = (x == o);
            Console.WriteLine("x {0}, o {1},  r {2}", x,o,r);

            
            
            string a = "-9 12 0 8 3 2 5";
            int[] arr = Array.ConvertAll(a.Split(' '), int.Parse);
            string res = arr.Max().ToString()+' '+arr.Min().ToString();
            Console.WriteLine(res);
            */
            //bool r = "G 9 R C x P 7 H D B e H P  " == ToMorse("G9RCxP7HDBeHP ");
            Motorcycle moto = new Motorcycle();
            moto.Name = "Jeff";
            moto.Miles = 200;
            moto.Owner = "Me";
            moto.Speed = 50;

        }

        public static string ToMorse(string englishStr)
        {
            string result = "";
            string[] words = englishStr.Split(' ');
            for (int e = 0; e < words.Length; e++)
            {
                char[] symbols = words[e].ToCharArray();
                for (int i = 0; i < symbols.Length; i++)
                {

                    result += symbols[i];
                    if (i < (symbols.Length - 1))
                        result += ' ';
                }
                if (words[e] != "" && e < (words.Length - 1) && words[e+1]!="")
                    result += "   ";
                else if (e < (words.Length - 1))
                    result += "  ";
            }
            return result;
        }

        static int vn()
        {
            int asd = 10;
            string aaa = Convert.ToString(asd, 2);
            return aaa.Count(i => i == '1');
            
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
