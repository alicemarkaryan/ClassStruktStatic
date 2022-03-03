using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruktStatic
{
    public class Car
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour {get; set; }

        public Car(string model, int price, int year, string colour)
        {
            this.Model = model; this.Price = price; this.Year = GetYear(year); 
            this.Colour = colour;
        }
        public int GetYear(int year)
        {
            if (year > 0)
            {
                return year;
            }
            return 2000;
        }

        public static void Go()
        {
            Console.WriteLine("static Go");
        }

        
    }
}
