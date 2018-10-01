using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class E6
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("exit point");
            Console.Read();
        }
    }
}
