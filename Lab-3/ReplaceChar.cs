using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class ReplaceChar
    {
        public ReplaceChar(string name) {
            char[] charArr = name.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsLower(charArr[i]))
                {
                    charArr[i]=char.ToUpper(charArr[i]);
                }
                else if(char.IsUpper(charArr[i]))
                {
                    charArr[i] = char.ToLower(charArr[i]);
                }
            }

            string charStr = new string(charArr);
            Console.WriteLine(charStr);

        }
    }
}
