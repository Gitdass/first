using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class Nine
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the First Integer:");
            int NUM1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Integer:");
            int Num2=Convert.ToInt32(Console.ReadLine());
            int Sum=NUM1 + Num2;
            if (NUM1 == Num2) 
               {
                Console.WriteLine($" Two values are equal then return the triple of their sum:{Sum * 3}");
               }
            else
            {
                Console.WriteLine($"The sum Value is:{Sum}");
            }
            Console.ReadLine();
        }
    }

}
