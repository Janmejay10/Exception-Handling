using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class F12
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the size of array");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
