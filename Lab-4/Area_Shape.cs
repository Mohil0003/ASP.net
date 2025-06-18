using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Area_Shape
    {
        public void Area(int l)
        {
            int area = l * l;
            Console.WriteLine("Area of Square is : "+area);
        }

        public void Area(int l, int w)
        {
            int area = l * w;
            Console.WriteLine("Area of Rectangle is : " + area);
        }
    }
}
