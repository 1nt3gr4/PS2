using System;
// Вычисление приближённого значения определённого интеграла
// по формуле левых прямоугольников и формуле Монте-Карло.
namespace integral._2
{
    class Program
    {
        static double f(double x)
        {
            return Math.Cos(1.0 / x + x * x / 4);
        }

        static void Main(string[] args)
        {
            double a = 0.5, b = 2, h, x = a, n;
            Double.TryParse(Console.ReadLine(), out n);
            h = (b - a) / n;
            double sum = 0;
            // Вычисление значения при помощи метода левых прямоугольников.
            for(int i = 0; i < n; i++)
            {
                x = a + i * h;
                sum += h*f(x);
            }
            Console.WriteLine(sum);
            sum = 0;
            x = 0;
            // Вычисление значения при помощи метода Монте-Карло.
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                x = a + h * r.Next((int)n);
                sum += h*f(x);
            }
            Console.WriteLine(sum);
        }
    }
}
