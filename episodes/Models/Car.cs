using System;
using System.Collections.Generic;

namespace episodes.Models
{
    public abstract class Car
    {
        public double Speed { get; protected set; } = 100;
        public double Acceleration { get; protected set; } = 10;
        public void Start()
        {
            Console.WriteLine("Turning on the engine...");
            Console.WriteLine($"Runing at: {Speed} km/h");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping the Car...");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
            Speed +=Acceleration;
            Console.WriteLine($"Speed is {Speed} km/h");
        }

        public abstract void Boost();
        
    }

    public class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Truck Accelerating...");
            Speed +=Acceleration;
            Console.WriteLine($"Truck Speed is {Speed} km/h");
        }

        public override void Boost()
        {
            Console.WriteLine("Truck Boosting...");
            Speed +=50;
            Console.WriteLine($"Truck boost Speed is {Speed} km/h");
        }
    }

    public class SportCar : Car 
    {
        public override void Accelerate()
        {
            Console.WriteLine("SportCar Accelerating...");
            Speed +=Acceleration;
            Console.WriteLine($"SportCar Speed is {Speed} km/h");
            
        }

        public override void Boost()
        {
            Console.WriteLine("SportCar Boosting...");
            Speed +=50;
            Console.WriteLine($"SportCar boost Speed is {Speed} km/h");        
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Display info.");
        }

    }

    public class Race
    {
        public void Begin()
        {
            SportCar sportCar = new SportCar();
            Truck truck = new Truck();

            List<Car> cars = new List<Car>
            {
                sportCar, truck
            };
            
            foreach(Car car in cars)
            {
                car.Start();
                car.Accelerate();
                car.Boost();
            }
        }

        public void Casting()
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            bool isSportCar = sportCar is SportCar;
            if(isSportCar)
            {
                
            }  
        }
    }

}