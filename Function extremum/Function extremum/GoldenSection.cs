using System;

namespace Function_extremum
{
    class GoldenSection
    {
        private const double PHI = 1.6180339887498949;

        /// <summary>
        /// Метод поиска минимума на заданном отрезке.
        /// </summary>
        /// <param name="func">Заданная функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>

        public double GetMax(Func<double, double> func, double a, double b, double e)
        {
            double x1;
            double x2;

            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) <= func(x2))
                    a = x1;
                else
                    b=x2;

                if (Math.Abs(b-a)<e)
                    break;
            }
        return (a + b) / 2;
        }

        public double GetMin(Func<double, double> func, double a, double b, double e)
        {
            double x1;
            double x2;

            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) >= func(x2))
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < e)
                    break;
            }
            return (a + b) / 2;
        }
    }
}
