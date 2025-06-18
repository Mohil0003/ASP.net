using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Furniture
    {
        public string Material;
        public int Price;

        public Furniture(string? Material, int Price)
        {
            this.Material = Material;
            this.Price = Price;
        }

    }

    class Table : Furniture
    {
 
        int Height;
        int Surface_Area;

        public Table(int Height, int Surface_Area, string? Material, int Price) : base(Material, Price)
        {
            this.Height = Height;
            this.Surface_Area = Surface_Area;
            Console.WriteLine(Material);
            Console.WriteLine(Price);
            Console.WriteLine(Height);
            Console.WriteLine(Surface_Area);

        }

    }
}
