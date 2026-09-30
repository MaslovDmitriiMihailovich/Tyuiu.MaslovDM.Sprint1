using System;
using Tyuiu.MaslovDM.Sprint1.Task6.V6.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Task6_Работа со строками класс String";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.DeleteFirstLetter(value);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}