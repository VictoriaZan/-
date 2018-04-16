using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclass
{
    class Motorcycle
    {
        public string Name;
        public int Speed;
        public string Owner;
        public int Miles;
        public static int St = 111;


        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeee Haaawwww!");
        }
/*
        public Motorcycle():this("I",22,"I",999) { }
        public Motorcycle(int speed) : this("Two", "Tho", 1415)
        { this.Speed = speed; }

        public Motorcycle(string name,string own, int miles)
        {
            this.Name = name;
            this.Owner = own;
            this.Miles = miles;
        }
        public Motorcycle(string name, int sp, string own, int ml)
        {
            this.Name = name;
            this.Speed = sp;
            this.Owner = own;
            this.Miles = ml;
        }
        */
     public Motorcycle(string Name = "Henry", int Speed = 45, string Owner = "Me", int Miles = 99999)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.Owner = Owner;
            this.Miles = Miles;
        }
        
}
}
