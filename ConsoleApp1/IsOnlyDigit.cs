using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class IsOnlyDigit
    {
        bool isOnlyDigit(string str)
        {
            if(string.IsNullOrEmpty(str)) return false;
            for(int i =0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i])) {
                    return false;
                }
            }
            return true;
        }
    
    }
}
