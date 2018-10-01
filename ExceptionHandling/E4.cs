using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class E4
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the numerator");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the denominator");
            int d = int.Parse(Console.ReadLine());
            if(d % 2 > 0)
            {
                throw new ApplicationException("divisor value should not be an odd number");
            }
            int a = n / d;
            Console.WriteLine("the result is:" + a);
            Console.WriteLine("exit point");
        }
    }
}
