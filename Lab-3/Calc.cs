using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
        public interface ICalculate
        {
            public  void Addition(int a, int b);

            public  void Subtraction(int a, int b);
        }

        public class Result : ICalculate
        {
            public void Addition(int a , int b) {
                int result = a + b;
            Console.WriteLine(result);

            }

            public void Subtraction(int a, int b) { 
                int result = a - b;
            Console.WriteLine(result);
            }

        }
         
    }
