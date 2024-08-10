using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please inter your target");
            int target = int.Parse(Console.ReadLine());

            for (int i = 1; i <= target; i++) 
            {
                if (i % 2== 0 ) 
                {
                    Console.Write($" {i} ");  
                }
            }
            Console.WriteLine();


           Console.ReadLine();


        }
    }
}
