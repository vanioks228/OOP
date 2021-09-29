using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_extremum
{
    class Dichotomy
    {
        /// <summary>
        /// Метод поиска минимума фунции на заданном отрезке
        /// </summary>
        /// <param name="func">Заданная функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>
        public double ExtrMin(Func<double, double> func, double a, double b, double e)
        {
            double x;

            while (true)
            {
                x = (a + b) / 2;

                if (func(x - e) <= func(x + e))
                    b = x;
                else
                    a = x;

                if (Math.Abs(b - a) <= e)
                    return x;
            }
        }

        /// <summary>
        /// Метод поиска максимума фунции на заданном отрезке
        /// </summary>
        /// <param name="func">Заданная функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>
        public double ExtrMax(Func<double, double> func, double a, double b, double e)
        {
            double x;

            while (true)
            {
                x = (a + b) / 2;

                if (func(x - e) >= func(x + e))
                    b = x;
                else
                    a = x;

                if (Math.Abs(b - a) <= e)
                    return x;
            }
        }
    }
}

