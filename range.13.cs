using System;

namespace range._13
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10000;
            double x;
            Double.TryParse(Console.ReadLine(), out x);
            double a = 1;
            double sum = a;

            for (int k = 0; k  < n; k ++)
            {
                a *= (-1) * x * (2 * k + 1) / (2 * k);
                sum += a;
            }

            Console.WriteLine($"С помощью функции: {1.0 / Math.Sqrt(1 + x)}");
            Console.WriteLine($"С помощью формулы: {sum}");
        }
    }
}
