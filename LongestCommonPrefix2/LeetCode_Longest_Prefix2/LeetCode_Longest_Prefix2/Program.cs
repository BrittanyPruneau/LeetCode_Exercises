using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Versioning;

namespace LeetCode_Longest_Prefix2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] { "brittany", "joe", "james", "paul" };
            string longest = names.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);

            //var texta = "first string";
            //var textb = "second string";
            var result = string.empty;

            for(int i = 0; i <names.longest)
            
            //for (int i = 0; i < longest.Length; i++)
            //{
            //    if (texta[i] != textb[i])
            //        break;
            //    else result += texta[i];
            }

            console.writeline("texta:  " + texta);
            console.writeline("textb:  " + textb);
            console.writeline();
            console.writeline("common prefix is:  '" + result + "'");


            console.readkey();

          //  string[] names = new string[4] { "brittany", "hikamealiafkjbdv", "james", "paul" };
          //  string longest = names.OrderByDescending(s => s.Length).First();
         //   Console.WriteLine(longest);

         //   string first = names[0];
          //  Console.WriteLine(first);
          //  Console.WriteLine(names.Length);
        }
    }
}

