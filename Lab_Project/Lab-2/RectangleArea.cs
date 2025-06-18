using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class RectangleArea
    {
        int Length;
        int Width;

        public RectangleArea(int Length, int Width)
        {
            this.Length = Length;
            this.Width = Width;
            Console.WriteLine("Area is : " +(Length * Width));
        }

    }
}
