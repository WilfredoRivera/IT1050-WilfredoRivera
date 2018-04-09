using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            int car1Speed = 20;
            int car2Speed = 0;
            car car1 = new car("Ford", "Focus", 2010, car1Speed);
            car car2 = new car("Chevy", "Cruze", 2018, car2Speed);

            for (int i = 0; i < 60; i++)
            {
                if (i % 2 == 0)
                {
                    car2Speed = car2.speedup();
                }
                if (i % 3 == 0)
                {
                    car1Speed = car1.speedup();
                }
                if (i % 5 == 0)
                {
                    car1Speed = car1.SlowDown();
                    car2Speed = car2.SlowDown();
                }
            }
            car1.Display();
            car2.Display();
        }




        class car
        {
            private int speed;
            private string make;
            private string model;
            private int year;
            public car(string make, string model, int year, int speed)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.speed = speed;
            }
            public car(string make, string model,int year)
               
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.speed = 0;
            }
            public int speedup()
            {
                speed++;
                return speed;
                
            }
            public int SlowDown()
            {
                speed--;
                return speed;
            }
            public void Display()
            {
                Console.WriteLine(year + " " + make + " " + model + " is going" + speed + "MPH.");
               
            }
              
              
            

        }
    }
}
