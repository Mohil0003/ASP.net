using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class ZeroException
    {   
        public void Division(int a, int b)
        {
            try
            {
                int result = b / a;
            }
            catch (DivideByZeroException e)    
            {
                Console.WriteLine("result : " + e);
            }
            finally{
                Console.WriteLine("Result Printed");
            }

        }
    }
}

