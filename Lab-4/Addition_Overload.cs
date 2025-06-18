using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Addition_Overload
    {
        public void Add(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition of Two INT : "+result);
        }

        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Addition of Two DOUBLE : " + result);
        }
    }
}
