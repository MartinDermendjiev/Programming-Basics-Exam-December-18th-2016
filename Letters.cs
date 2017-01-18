using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Letters
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string thirdLetter = Console.ReadLine();
            int Count = 0;
            for (char i = char.Parse(firstLetter); i <= char.Parse(secondLetter); i++)
            {
                for (char j = char.Parse(firstLetter); j <= char.Parse(secondLetter); j++)
                {
                    for (char k = char.Parse(firstLetter); k <= char.Parse(secondLetter); k++)
                    {
                        if(i != char.Parse(thirdLetter) && j != char.Parse(thirdLetter) &&
                            k != char.Parse(thirdLetter))
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            Count++;
                        }
                    }
                }
            }
            Console.WriteLine(Count);
        }
    }
}
