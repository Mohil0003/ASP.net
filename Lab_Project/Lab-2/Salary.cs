using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Salary
    {
        int basic;
        int TA;
        int DA;
        int HRA;
        int TotalSalary;

        public Salary(int basic , int TA , int DA , int HRA)
        {

            TotalSalary = basic + TA + DA + HRA;
            Console.WriteLine("Total Salary is : " + TotalSalary);
        }

    }
}
