using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstNonRepeatedCharacter

    {

        char findNonRepeatedCharacter(string str)
        {
            Dictionary<char, int> maps = new Dictionary<char, int>();
            while (str.Equals(""))
            {
                if (!str.Equals(""))
                {
                    break;
                }

                Console.WriteLine("Please Enter The String :");
                str = Console.ReadLine();
            }

            if (str.Length == 1)
            {
                Console.WriteLine("The Non_Repeated Character is : " + str[0]);
            }

            char res = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                if (!(maps.ContainsKey(str[i])))
                {
                    maps.Add(str[i], 1);
                }
                else
                {
                    maps[str[i]]++;
                }
            }

            foreach (char c in maps.Keys)
            {
                if (maps[c] == 1)
                {
                    res = c; break;

                }
            }
            return res;
        }

    }
}
