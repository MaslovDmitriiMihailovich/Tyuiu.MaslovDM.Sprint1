using System;
using Tyuiu.MaslovDM.Sprint1.Task2.V18.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c;

            Console.WriteLine("Введите значение a (длина):");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b (ширина):");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c (высота):");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь боковой поверхности = " + ds.CalculateSideSquareParallelepiped(a, b, c));

            Console.ReadLine();
        }
    }
}