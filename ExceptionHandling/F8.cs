using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class F8
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (NullReferenceException e) // because DivideByZeroException was about to be here
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("some important statements(closing statement");
            }
            Console.WriteLine("exit point");
            Console.Read();
        }
    }
}
