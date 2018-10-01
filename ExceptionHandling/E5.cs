using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number";
            }
        }
    }
    class E5
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("enter the numerator");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the denominator");
            int d = int.Parse(Console.ReadLine());
            if (d % 2 > 0)
            {
                //    throw new ApplicationException("divisor value should not be an odd number");
                throw new DivideByOddNoException();
            }
            int a = n / d;
            Console.WriteLine("the result is:" + a);
            Console.WriteLine("exit point");
        }
    }
}

