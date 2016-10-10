using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;

            for(int i = 40; i > 0; i--)
                y = Math.Cos(y + i);

            Console.WriteLine(y);
        }
    }
}
