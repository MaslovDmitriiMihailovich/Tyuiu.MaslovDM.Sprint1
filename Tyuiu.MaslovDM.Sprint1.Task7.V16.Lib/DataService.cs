using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaslovDM.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double numerator = Math.Cos(Math.Pow(x, 2));
            double denominator = 3 * Math.Pow(x, 3);

            double term1 = Math.Sin(Math.Sqrt(Math.Pow(x, 2) + (numerator / denominator)));
            double term2 = Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));

            double z = term1 - term2;
            return Math.Round(z, 3);
        }
    }
}