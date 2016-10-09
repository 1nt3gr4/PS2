using System;
// Вычисление по итерационной формуле кубического корня.
namespace iter._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int eps = 1000;
            double x;
            int n = 0;
            Double.TryParse(Console.ReadLine(), out x);
            double y;

            if (x >= 1)
                y = (double)x / 3;
            else
                y = x;

            while (n < eps)
            {
                y -= 0.3333 * (y - x / (y * y));
                n++;
            }
            Console.WriteLine(y);
        }
    }
}
