using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Candidate
    {
        int ID;
        string Name;
        int Age;
        int Weight;
        int Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age : ");
            Age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight : ");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height : ");
            Height = Convert.ToInt32(Console.ReadLine());
        }


        public void DisplayCandidateDetails()
        {
            Console.WriteLine("The Member's Details is : ");
            Console.WriteLine("ID is " + this.ID);
            Console.WriteLine("Name is " +this.Name);
            Console.WriteLine("Age is " + this.Age);
            Console.WriteLine("Weight is " + this.Weight);
            Console.WriteLine("Height is " + this.Height);

        }


    }
}
