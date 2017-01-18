using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {

            double StartingSpeed = double.Parse(Console.ReadLine());
            double FirstTimeInMinutes = double.Parse(Console.ReadLine());
            double SecondTimeInMinutes = double.Parse(Console.ReadLine());
            double ThirdTimeInMinutes = double.Parse(Console.ReadLine());
            double StartingSpeedPlusTenProsent = (StartingSpeed * 110 / 100);

            double FirstDistance = StartingSpeed * FirstTimeInMinutes / 60.00;
            double SecondDistance = StartingSpeed * 110 / 100 * 
                SecondTimeInMinutes / 60.00;
            double ThirdDistance = StartingSpeedPlusTenProsent * 95 / 
                100 * ThirdTimeInMinutes / 60.00;
            double result = FirstDistance + SecondDistance + ThirdDistance;
             Console.WriteLine("{0:f2}", result);
        }
    }
}
