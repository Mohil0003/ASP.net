using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Student
    {
        string Enrollment_No;
        string Student_Name;
        double SPI;
        double CPI;

        public Student(string enrollment_No, string student_Name, double sPI, double cPI)
        {
            Enrollment_No = enrollment_No;
            Student_Name = student_Name;
            SPI = sPI;
            CPI = cPI;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student's Details : ");
            Console.WriteLine("Enrollment Number is " + Enrollment_No);
            Console.WriteLine("Name is "+Student_Name);
            Console.WriteLine("SPI is "+SPI);
            Console.WriteLine("CPI is"+ CPI);
        }
    }
}
