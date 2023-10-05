using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class three
    {
       static void Main(string[] args)
        {
             int firstnumber, secondnumber;
            Console.WriteLine("Input the first number:");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
            Console.WriteLine($" {firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
            Console.WriteLine($" {firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
            Console.WriteLine($" {firstnumber} / {secondnumber} = {firstnumber /secondnumber}");
            Console.WriteLine($" {firstnumber} mod {secondnumber} = {firstnumber % secondnumber}");
            
            Console.ReadLine();
        }
    }
}
