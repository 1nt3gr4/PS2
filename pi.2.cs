using System;
// Вычисление значения числа Пи с точностью e при помощи формулы произведения Валлиса.
namespace pi._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 1.0000000001;
            double k = 2;
            double po = 1.333333333;
            double p = 1;

            while (po > eps)
            {
                p *= po;
                po = 4 * k * k / (4 * k * k - 1);
                k++;
            }
            Console.WriteLine(p * 2);
            Console.WriteLine(Math.PI);
        }
    }
}
