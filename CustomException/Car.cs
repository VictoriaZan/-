using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomException
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed >= MaxSpeed)
                {
                    
                    CurrentSpeed = 0;
                    carIsDead = true;
                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!!!", PetName), "speed", DateTime.Now);
                    ex.HelpLink = "https://www.Help.com";
                    ex.Data.Add("TimeStamp", string.Format("Time {0}", DateTime.Now));
                    ex.Data.Add("Cause", string.Format("speed"));
                    throw ex;
                    
                }
                else
                    Console.WriteLine("Current speed is {0}", CurrentSpeed);

            }

        }
    }
}
