using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class IndexException
    {
        int []arr = new int [5];
        public void GetNumbers()
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter Number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayArray(int n)
        {
            try
            {
                Console.WriteLine("Number is :" + arr[n]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}
