//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class ReverseString
//    {
//        class ReverseString
//        {
//            public static string reverseString(string str)
//            {
//                if (string.IsNullOrEmpty(str))
//                {
//                    Console.WriteLine("Please The string is Empty");
//                    return string.Empty;
//                }

//                if (!str.Contains(" "))
//                {
//                    return str;
//                }
//                else
//                {
//                    int index = str.IndexOf(" ");

//                    return reverseString(str.Substring(index + 1)) + " " + str.Substring(0, index);
//                }
//            }
//        }
//    }

//}
