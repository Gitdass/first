using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class Ten
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int num2=Convert.ToInt32(Console.ReadLine());       
            int AbsoluteValue=Math.Abs(num1-num2);
            int result = 2 * AbsoluteValue;
            if(num1>num2)
                {
                Console.WriteLine($"The first number is grater then number two so the value is Double:{result}");
              
                 }
            else
            {
                Console.WriteLine($"the Absolute Value Is:{AbsoluteValue}");
            }

            Console.ReadLine();
        }
    }
}
