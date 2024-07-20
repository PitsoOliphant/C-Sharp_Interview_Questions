using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2,3, 4, 5, 6};
            int sum = 0;
            int target = 11;
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum = numbers[i] + numbers[i]+1;
                if(sum==target)
                {
                    Console.WriteLine($"{numbers[i]} and {numbers[i] + 1} equals to {sum}");
                    break;
                }
                else { Console.WriteLine($"{numbers[i]} and {numbers[i] + 1} is not equals to {target}"); }
            
            }
            Console.ReadLine();
        }
    }
}
