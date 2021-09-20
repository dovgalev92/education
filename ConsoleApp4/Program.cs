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
            Console.WriteLine("Таблица сложения от 0 до 9");
            
           
            for(int num = 0, a= 5; num < 10; num+=a)
            {
                for(int num2 = 0;num2<10;++num2)
                {
                    for (int num3 = num; num3 < num + a; ++num3)
                        Console.Write("{0} + {1} = {2,3}  ", num, num2, num + num2);
                        Console.WriteLine();
                }
                        Console.WriteLine();
            }
            Console.ReadKey();
        }  
    }
}
