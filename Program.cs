using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 20, 16, 2 };
            int temp = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if (numbers[i]>numbers[j])
                    {
                        temp=numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;  
                    }
                }
            }
            foreach( int i in numbers)
            {
                Console.Write(i+"\t");
            }
            Console.ReadLine();
        }
    }
}
