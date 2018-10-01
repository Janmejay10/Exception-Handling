using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class E3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the elements of array");
            for(int i = 0;i <= n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = arr[9];  // ArrayIndexOutOfBound Exception

        }
    }
}
