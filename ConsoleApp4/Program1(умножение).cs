using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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

            char s;
            char[] symb = { 'R', 'D', 'A', 'S', 'Q', 'O' };
            Console.WriteLine("Массив до перебора");
            for (int i = 0; i < symb.Length; i++)
            {
                Console.Write(symb[i] + " ");
            }

            Console.WriteLine();
            for(int k = 1; k < symb.Length;k++)
            {
                for(int j = 0;j< symb.Length - k; j++)
                {
                    if (symb[j] > symb[j + 1])
                    {
                        s = symb[j + 1];
                        symb[j + 1] = symb[j];
                        symb[j] = s;
                  
                    }
                } 
                
            }
                Console.WriteLine("Массив после сортировки");
            for (int i = 0; i < symb.Length; i++)
                Console.Write(symb[i] + " ");
            Console.ReadKey();
        }

                
               
     
        

       

       
        
    }
}
