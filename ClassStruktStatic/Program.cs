using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruktStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Mercedes",22000,2009,"Red");
            Console.WriteLine(c.Model);
            BMW bmw = new BMW("BMW 5", 35000, 2012, "Rose", 2.5);
            Console.WriteLine(bmw.Price);
            A s1;
            s1.a = 333;
            s1.f();
            //s1.Func(); Error
            A.Func();
            Car.Go();
        }
        
    }
}
