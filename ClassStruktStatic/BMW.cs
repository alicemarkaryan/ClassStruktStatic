using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruktStatic
{
    internal class BMW:Car
    {
        public double Power { get; set; }

        public BMW(string model, int price, int year, string colour, double Power):
            base (model, price, year, colour) 
        {
            this.Power=Power;
        }

    }
}
