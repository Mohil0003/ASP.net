using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class RBI
    {
        public int P = 1000;
        public int T = 3;
        public virtual void CalculateInterest(int R)
        {
            int I = (P * R * T) / 100;
            Console.WriteLine("Interest of RBI is : " + I);
        }
    }

    public class HDFC : RBI
    {
        public override void CalculateInterest(int R) {
            int I = (P * R * T) / 100;
            Console.WriteLine("Interest of HDFC is : " + I);
        }

    }
    public class SBI : RBI
    {
        public override void CalculateInterest(int R)
        {
            int I = (P * R * T) / 100;
            Console.WriteLine("Interest of SBI is : " + I);
        }

    }

    public class ICICI : RBI
    {
        public override void CalculateInterest(int R)
        {
            int I = (P * R * T) / 100;
            Console.WriteLine("Interest of ICICI is : " + I);
        }

    }
}