using System;
using System.Collections.Generic;

namespace Lab_5
{
    public class StudentList
    {
        List<string> StudentNames = new List<string>();

        public void Add(string name)
        {
            StudentNames.Add(name);
            Console.WriteLine($"Student '{name}' added.");
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < StudentNames.Count)
            {
                Console.WriteLine($"Student '{StudentNames[index]}' removed.");
                StudentNames.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void RemoveRange(int startIndex, int count)
        {
            if (startIndex >= 0 && startIndex + count <= StudentNames.Count)
            {
                StudentNames.RemoveRange(startIndex, count);
                Console.WriteLine($"Removed {count} students starting from index {startIndex}.");
            }
            else
            {
                Console.WriteLine("Invalid range.");
            }
        }

        public void Clear()
        {
            StudentNames.Clear();
            Console.WriteLine("All students cleared from the list.");
        }

        public void Display()
        {
            if (StudentNames.Count == 0)
            {
                Console.WriteLine("Student list is empty.");
            }
            else
            {
                Console.WriteLine("List of Students:");
                foreach (string student in StudentNames)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
