using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "pitso";
            string reversedName = "";

            
            for (int i = name.Length-1; i >=0; i--)
            {
                reversedName += name[i];
               
            }

           Console.WriteLine(reversedName = char.ToUpper(reversedName[0]) + reversedName.Substring(1));
           Console.ReadLine();
        
             
        }
    }
}
