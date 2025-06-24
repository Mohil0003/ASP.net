using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Lab_5
{
   public class Arraylist
    {

       
            ArrayList StudentName = new ArrayList();

            public void Add(string Name)
            {
                StudentName.Add(Name);
                Console.WriteLine("After Student added");
            }




            public void Remove(int index)
            {
                if (index >= 0 && index < StudentName.Count)
                {
                    StudentName.RemoveAt(index);
                    Console.WriteLine("student removed");
                }
                else
                {
                    Console.WriteLine("Invalid Index");

                }
            }



            public void RemoveRange(int startIndex, int count)
            {
                for (int i = startIndex; i <= count; i++)
                {
                    Remove(i);
                }
            }



           public void CLear()
            {
                StudentName.Clear();
                Console.WriteLine("All Student Clear from ArrayList.");
            }

             public void Display()
            {
                if (StudentName == null)
                {
                    Console.WriteLine("Student List Empty");
                }
                else
                {
                    foreach (object stu in StudentName)
                    {
                        Console.WriteLine(stu);
                    }
                }




            }
        }
    }
