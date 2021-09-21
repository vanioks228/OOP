using System;

namespace Golden_section_search
{
    class Program
    {
        class GoldenSection
        {
            public static void Main(String[] args)
            {
                GoldenSection GS = new GoldenSection();
                System.Console.WriteLine(GS.FindMin(-2, 2, 0.001));
                System.Console.WriteLine(GS.FindMax(-8, 0, 0.001));
            }

            double PHI = (1 + Math.Sqrt(5)) / 2;

            static double F(double x)
            {
                return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
            }

            double FindMin(double a, double b, double e)
            {
                double x1, x2;
                while (true)
                {
                    x1 = b - (b - a) / PHI;
                    x2 = a + (b - a) / PHI;
                    if (F(x1) >= F(x2))
                        a = x1;
                    else
                        b = x2;
                    if (Math.Abs(b - a) < e)
                        break;
                }
                return (a + b) / 2;
            }

            double FindMax(double a, double b, double e)
            {
                double x1, x2;
                while (true)
                {
                    x1 = b - (b - a) / PHI;
                    x2 = a + (b - a) / PHI;
                    if (F(x1) <= F(x2))
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
}
