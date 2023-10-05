using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class seven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            Double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            Double num2=Convert.ToDouble(Console.ReadLine());
            Double max=Math.Max(num1,num2);
            Double min=Math.Min(num1,num2);
            Console.WriteLine($"The maximum number{max}");
            Console.WriteLine($"The minimum number{min}");
            Console.ReadLine();      
        }
    }
}
