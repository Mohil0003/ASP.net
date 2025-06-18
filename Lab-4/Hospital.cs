using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Hospital
    {
        public virtual void HospitalDetails(string name , string add)
        {
            Console.WriteLine(name);
            Console.WriteLine(add);
        }
    }

    public class Apollo : Hospital {
        public override void HospitalDetails(string name, string add)
        {
            Console.WriteLine($"Hospital name is {name} and Address is {add}");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails(string name, string add)
        {
            Console.WriteLine($"Hospital name is {name} and Address is {add}");
        }
    }

    public class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails(string name, string add)
        {
            Console.WriteLine($"Hospital name is {name} and Address is {add}");
        }
    }
}
