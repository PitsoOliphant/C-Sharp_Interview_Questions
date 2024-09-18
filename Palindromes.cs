using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    internal class Program
    {
        static bool Palindrome(string input)
        {
            bool result=true;
            string palindrom = "";

            for (int j = input.Length - 1; j >= 0; j--)
            {

                palindrom += input[j];
                

            }
           
            for(int i =0;i< palindrom.Length;i++)
            {
                if(input[i] == palindrom[i]) result = true ;
                else result = false;
            }
            
            
                return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Palindrome");
            string UserInput =Console.ReadLine();

            Console.WriteLine(Palindrome(UserInput[0].ToString().ToLower()+UserInput.Substring(1)));

            Console.ReadLine();

        }
    }
}
