using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaslovDM.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }
    }
}