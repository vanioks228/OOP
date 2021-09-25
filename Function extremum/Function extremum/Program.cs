using System;

namespace Function_extremum
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldenSection gs = new GoldenSection();
            double max = gs.GetMax(Function, -8.0, 0.0, 0.0001);
            double min = gs.GetMin(Function, -2.0, 2.0, 0.0001);
            Console.WriteLine($"Max:{max}, Min:{min}");
        }
        static double Function(double x) => Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
    }
}
