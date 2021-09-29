using System;

namespace Function_extremum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dichotomy dicht = new();
            GoldenSection gs = new();

            Console.WriteLine("Метод золотого сечния:");
            Console.WriteLine("Интервал: [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + gs.GetMin(Function, -2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + gs.GetMax(Function, -2, 2, 0.001));
            Console.WriteLine("Интервал: [0;8]");
            Console.WriteLine("Точка минимума функции:x=" + gs.GetMin(Function, 0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + gs.GetMax(Function, 0, 8, 0.001));

            Console.WriteLine("\nМетод дехотомии:");
            Console.WriteLine("Интервал: [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + dicht.ExtrMin(Function, -2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + dicht.ExtrMax(Function, -2, 2, 0.001));
            Console.WriteLine("Интервал: [0;8]");
            Console.WriteLine("Точка минимума функции:x=" + dicht.ExtrMin(Function, 0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + dicht.ExtrMax(Function, 0, 8, 0.001));
        }
        static double Function(double x) => Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
    }
}
