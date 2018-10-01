using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class F11
    {
        static void Main(string[] args)
        {
            {
                unchecked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val);
                    Console.WriteLine(val + 2);
                }
            }
            Console.Read();
        }
    }
}
