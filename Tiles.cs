using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki
{
    class Plochki
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal floorWight = decimal.Parse(Console.ReadLine());
            decimal floorLenght = decimal.Parse(Console.ReadLine());
            decimal triangleSide = decimal.Parse(Console.ReadLine());
            decimal triangleHeight = decimal.Parse(Console.ReadLine());
            decimal PlochkaPrice = decimal.Parse(Console.ReadLine());
            decimal sumaMaistor = decimal.Parse(Console.ReadLine());
            decimal floorArea = floorLenght * floorWight;
            decimal triangleArea = triangleSide * triangleHeight / 2;
            decimal plochkaRequired = Math.Ceiling(floorArea / triangleArea + 5);
            decimal sumaPlochki = PlochkaPrice * plochkaRequired + sumaMaistor;

            if(money >= sumaPlochki)
            {
                Console.WriteLine("{0:f2} lv left.", money - sumaPlochki);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", sumaPlochki - money);
            }



        }
    }
}
