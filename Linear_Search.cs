using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            string[] name = { "112", "001", "10" };
            string userInput =Console.ReadLine();
            for(int i =0;i< name.Length;i++)
            {
                if (userInput == name[i])
                {
                    Console.WriteLine(name[i]);
                    break;
                }
                else
                {
                     Console.WriteLine("Does not exist");
                    break;
                }
            }
            Console.ReadLine();

        }
    }
    

 }

    

