using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert.ToInt32(Console.ReadLine()) - fast convert string from console to integer
            int n = Convert.ToInt32(Console.ReadLine());
            // Console.ReadLine().Split() - read the string from console and split this string
            string[] num = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                // int.Parse - convert method from string to int 
                int b = int.Parse(num[i]);
                for (int j = 1; j <= 2; j++)
                {
                    // output
                    Console.Write(b + " ");
                }
            }
        }
    }
}
