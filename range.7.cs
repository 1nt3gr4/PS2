using System;

namespace range._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, eps;
            Double.TryParse(Console.ReadLine(), out x);
            Double.TryParse(Console.ReadLine(), out eps);
            double a = 1.0 / x;
            double sum = a;
            double b = 0;
            int k;

            for (k = 1; a >= eps; k++)
            {
                a *= (-1) / (x * x);
                b = a / (2 * k + 1);
                sum += b;
            }

            sum = Math.PI * Math.Sqrt(x * x) / (2 * x) - sum;
            Console.WriteLine($"С помощью функции: {Math.Atan(x)}");
            Console.WriteLine($"С помощью формулы: {sum}");
            Console.WriteLine($"Заданная точность достигается при k = {k}");
        }
    }
}
