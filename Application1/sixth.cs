using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    internal class sixth
    {
       static void Main(string[] args)
        {
            double sub1,sub2,sub3;
            double totalmark, percentage;
        
            Console.WriteLine("Enter the sub1");
            sub1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the sub2");
            sub2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the sub3");
            sub3 =Convert.ToDouble(Console.ReadLine());
            totalmark = sub1 + sub2 + sub3;
            percentage =(totalmark/300)*100;
            if(percentage <35)
            {
                Console.WriteLine("fail");
            }
            else if(percentage >=35 &&percentage< 45)
                {
                Console.WriteLine("Third");

            }
            else if (percentage >= 45 && percentage < 60)
            {
                Console.WriteLine("Second");
            }
            else if (percentage >= 60 && percentage <= 100)
            {
                Console.WriteLine("first");
        
           }
            Console.ReadLine();
        }

    }
}
