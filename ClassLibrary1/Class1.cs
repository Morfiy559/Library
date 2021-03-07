using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void SumFunc(double x)
        {
            double Area = Math.Pow(x,2) * Math.PI;
            Console.WriteLine("Summ = {0}", Area);
            Console.ReadLine();
        }
        public static void SumFunc(double A, double B, double C)
        {
            double p, S;
            p = (A + B + C) / 2;

            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            Console.WriteLine("Площадь равна: {0}", S);
            Console.ReadLine();
        }
    }
}
