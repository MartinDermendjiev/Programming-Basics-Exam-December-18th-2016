using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            double CountOfStudents = double.Parse(Console.ReadLine());
            double CountOfGrades2 = 0;
            double CountOfGrades3 = 0;
            double CountOfGrades4 = 0;
            double CountOfGrades6 = 0;
            double SumOfGrades = 0;

            for (int i = 1; i <= CountOfStudents; i++)
            {
                double Grade = double.Parse(Console.ReadLine());
                SumOfGrades += Grade;
                if (Grade >= 2.00 && Grade <= 2.99)
                {
                    CountOfGrades2++;
                }
                else if (Grade >= 3.00 && Grade <= 3.99)
                {
                    CountOfGrades3++;
                }
                else if (Grade >= 4.00 && Grade <= 4.99)
                {
                    CountOfGrades4++;
                }
                else if (Grade >= 5.00)
                {
                    CountOfGrades6++;
                }

            }
            double Average = SumOfGrades / CountOfStudents;
            double Grade2Procent = (CountOfGrades2 / CountOfStudents) * 100;
            double Grade3Procent = (CountOfGrades3 / CountOfStudents) * 100;
            double Grade4Procent = (CountOfGrades4 / CountOfStudents) * 100;
            double Grade6Procent = (CountOfGrades6 / CountOfStudents) * 100;

            Console.WriteLine("Top students: {0:f2}%", Grade6Procent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", Grade4Procent);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", Grade3Procent);
            Console.WriteLine("Fail: {0:f2}%", Grade2Procent);
            Console.WriteLine("Average: {0:f2}", Average);
        }
    }
}
