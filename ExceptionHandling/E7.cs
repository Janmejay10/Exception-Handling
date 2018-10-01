using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class E7
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    int a = 10;
                    int b = 0;
                    int x = a / b;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("some mandatory statements");
                }
                Console.WriteLine("exit point");
            }
            Console.Read();
        }
    }
}
