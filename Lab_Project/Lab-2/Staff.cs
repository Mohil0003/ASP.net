using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Staff
    {
        string name;
        string Department;
        string Designation;
        int experience;
        int salary;

        public void GetDetails()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Department : ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Designation : ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Expereince : ");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStaff()
        {
            if(Designation == "HOD")
            {
                Console.WriteLine(name);
            }
        }
    }
}
