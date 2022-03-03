using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruktStatic
{
    
    public struct A
      {
        public int a; 
        public void f()
        {
            Console.WriteLine("Strukt function");
        }

        public static void Func()
        {
            Console.WriteLine("static Function");
        }

      }
    
}
