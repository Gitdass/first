using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class Eleven
    {
       static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;
            int remainingDays = days % 365;
            int weeks = remainingDays / 7;
             remainingDays = remainingDays % 7;

            Console.WriteLine($"{days} days is approximately:");
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{remainingDays} days");
            Console.ReadLine();
        }
    }
}
