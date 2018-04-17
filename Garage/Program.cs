using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.PetName = "Asa";
            Garage newGarage = new Garage(newCar, 1);
            Console.WriteLine("Name {0}", newGarage.MyAuto.PetName);
        }
    }
    class Garage
    {
        private int numbCar;
        private Car auto;
        public int NumberOfCars { get; set; }
        public Car MyAuto { get; set; }
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
