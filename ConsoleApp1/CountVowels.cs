using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountVowels
    {
        public int countVowels(string str)
        {
            HashSet<char> result = new HashSet<char>() { 'a', 'i', 'o', 'e', 'u' };
            int count = 0;

            if (str.Equals(""))
            {
                Console.WriteLine("Please the string is empty, so there is no any vowels !");
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (result.Contains(str[i]))
                    {
                        count++;

                    }
                }


            }
            return count;

        }

    }
}



