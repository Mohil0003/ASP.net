using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Distance
    {
        public int dist1;
        public int dist2;
        public int dist3;

        public Distance(int dist1, int dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        } 

        public void Addition_Dist()
        {
            dist3 = dist1 + dist2;
        }

        public void Display()
        {
            Console.WriteLine("Distance 1 : " + dist1);
            Console.WriteLine("Distance 2 : " + dist2);

            Console.WriteLine("Total Distance = "+dist3);
        }
    }
}
