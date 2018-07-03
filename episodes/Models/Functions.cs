using System;
using System.Threading;

namespace episodes.Models
{
    public class Delegates
    {
        public delegate void Write(string message);
        public delegate int Add(int a , int b);
        public delegate void Alert(int change);
        public void Test()
        {
            Write writer = WriteMessage;
            Add adder = Sum;
            var x = adder(1,2);
            writer("message");
            CheckTemperature(TooLowAlert,OptimalAlert,TooHighAlert);
        }
        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperature is too Low :{change}");
        }
        public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperature is optimal :{change}");
        }
        public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperature is too High :{change}");
        }
        public static void CheckTemperature(Alert tooLow, Alert optimal, Alert tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while(true)
            {
                var change = random.Next(-5,5);
                temperature += change;
                Console.WriteLine($"Temp. : {temperature}");
                if(temperature<=0)
                    tooLow(change);
                else if(temperature > 0 && temperature<=10)
                    optimal(change);
                else
                    tooHigh(change);
                Thread.Sleep(500);
            }
        }
        public static int Sum(int a, int b)
        {
            return a+b;
        }
        public static void WriteMessage(string message)
        {
            Console.WriteLine($"Hello: {message}");
        }
    }

    public class LambdaExpressions
    {
        
        public void Test()
        {
            Action writer = () => Console.WriteLine("Writing...");
            // Action<string,int> advanceWriter = (x,y) => Console.WriteLine($"{x} , {y}") ;
            // advanceWriter("XD", 5);

            // Func<int,int,string> adder =(x,y) => {return (x+y).ToString();};

            Func<int,int,string> adder =(x,y) => (x+y).ToString();

            Console.WriteLine(adder(1,2));
            writer();

            Action<int,string> logger =(x,y)=> 
            {
                Console.WriteLine($"Temperature is: {x}, message: {y}");
            };

            CheckTemperature(t => logger(t,"Too Low"),t => logger(t,"Optimal"),t => logger(t,"Too High"));
            
        }
        public static void CheckTemperature(Action<int> tooLow, Action<int> optimal, Action<int> tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while(true)
            {
                var change = random.Next(-5,5);
                temperature += change;
                Console.WriteLine($"Temp. : {temperature}");
                if(temperature<=0)
                    tooLow(temperature);
                else if(temperature > 0 && temperature<=10)
                    optimal(temperature);
                else
                    tooHigh(temperature);
                Thread.Sleep(500);
            }
        }
    }

    public class Events
    {
        public delegate void UpdateStatus(string status);
        public event UpdateStatus StatusUpdated;
        public EventHandler StatusUpdatedAgain;
        public void StartUpdatingStatus()
        {
            while(true)
            {
                var message = $"status, ticks {DateTime.UtcNow.Ticks}";

                StatusUpdated?.Invoke(message);
                
                Thread.Sleep(500);
            }
        }
    }
    public class EventsSandbox
    {
        public void Test()
        {
            var events = new Events();
            events.StatusUpdated += message => Console.WriteLine(message);
            events.StartUpdatingStatus();
        }
        public void DisplayStatus(string message)
        {
           Console.WriteLine(message); 
        }
    }
}