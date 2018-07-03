using System;
using episodes.Models;

namespace episodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var fun = new Delegates();   
            // fun.Test();    

            // var fun = new LambdaExpressions();
            // fun.Test(); 

            var fun = new EventsSandbox();
            fun.Test();
        }
    }
}
