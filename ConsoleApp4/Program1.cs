using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\ty/x|  1   2   3   4   5   6   7   8   9");
            Console.Write("       _________________________________________");
            Console.WriteLine();

            for (int x = 1; x < 10; x++)
            {
                Console.Write($"\t {x} |");

            for (int y = 1; y < 10; y++)
                {
                    Console.Write("{0,2}{1,2}", string.Empty, x * y);
                  
                }
                Console.WriteLine(string.Empty);
                Console.WriteLine("");
                

            }
            Console.ReadKey();
        }
           






    }
        
        
       
          
    
}
