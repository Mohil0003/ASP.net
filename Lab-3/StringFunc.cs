using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class StringFunc
    {
        public StringFunc(string name) { 
            Console.WriteLine("Lower : "+name.ToLower());
            Console.WriteLine("Upper : "+name.ToUpper());
            Console.WriteLine("Length : "+name.Length);
            Console.WriteLine(name.Replace("Mohil" ,"Parmar"));
            Console.WriteLine("Index of M :" + name.IndexOf("M"));
            Console.WriteLine("After Concat : "+string.Concat(name," P"));
            Console.WriteLine("Remove : "+name.Remove(2, 3));
            Console.WriteLine("Contains : "+name.Contains("M"));
            Console.WriteLine(name.Insert(3, "Parmar"));

        }
    }
}
