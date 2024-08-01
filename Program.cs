using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greatestValue = 0;
            int[] numbers = { 2, 5, 1, 22, 0 };
            int temp;
            for (int i = 0; i < numbers.Length-1; i++) 
            {
                for (int j = i+1;j<numbers.Length;j++) 
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }


                }
            }
            
            foreach (int i in numbers) 
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
