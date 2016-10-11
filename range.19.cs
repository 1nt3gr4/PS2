using System;

// Вычисление pi*pi/18 по формуле суммы от m = 1 до бесконечности, где a = [(m-1)!]2 / (2m!).
namespace range._19
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 0.000000001;
            double m = 2, a = 0.5, sum = 0;

            while (a > eps)
            {
                sum += a;
                a *= (m - 1) * (m - 1) / (m + 1) / (m + 2);
                m++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(Math.PI * Math.PI / 18);
            Console.WriteLine(m);
        }
    }
}
