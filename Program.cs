using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0&&i%5==0)
                {

                    word = "FizzBuzz";
                    Console.WriteLine(word);
                  
                }
                else if (i % 5 == 0)
                {
                    word = "Buzz";
                    Console.WriteLine(word);

                }
                else if (i % 3 == 0)
                {
                    word = "Fizz";
                    Console.WriteLine(word);

                }
                else
                {
                    Console.WriteLine(i);  
                }

           
            }
            Console.ReadLine();
        }
    }
}
