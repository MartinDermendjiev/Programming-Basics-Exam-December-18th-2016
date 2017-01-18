using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("/");
            Console.Write("|");
            Console.Write("\\");
            Console.WriteLine(new string('.', 2 * n - 1));

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\");
            Console.Write("|");
            Console.Write("/");
            Console.WriteLine(new string('.', 2 * n - 1));

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("*");
            Console.Write("*");
            Console.Write("*");
            Console.WriteLine(new string('.', 2 * n - 1));

            for (int i = 0; i < n * 2 - 1; i++)
            {
                Console.Write(new string('.', n * 2 - 2 - i));
                Console.Write("*");
                Console.Write(new string('-', i + 1));
                Console.Write("*");
                Console.Write(new string('-', i + 1));
                Console.Write("*");
                Console.WriteLine(new string('.', n * 2 - 2 - i));
            }
            Console.WriteLine(new string('*', n * 4 + 1));


            for (int j = 0; j < n * 2; j++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.Write("*");
            Console.WriteLine();

            Console.WriteLine(new string('*', n * 4 + 1));
        }
    }
}
