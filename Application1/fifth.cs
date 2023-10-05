using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class fifth
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Using Console.Write
            Console.Write("{0} {0} {0} {0}\n", number);
            Console.Write("{0}{0}{0}{0}\n", number);

            // Using {0} formatting
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadLine();
        }
    }
}
