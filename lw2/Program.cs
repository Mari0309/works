using System;
using System.Text.RegularExpressions;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex space = new Regex("  ");
            string inputFirst = "Сколько еще дней ";
            string inputSecond = "Сколькоо еще дней до дома";
            int wordsCount = 0;
            while (inputFirst.Contains("  "))
            {
                inputFirst = space.Replace(inputFirst, " ");
            }

            string[] wordsFirstString = inputFirst.Split(" ");
            string[] wordsSecondString = inputSecond.Split(" ");

            for (int i = 0; i < wordsFirstString.Length; i++)
            {
                wordsCount = 0;
                for (int j = 0; j < wordsSecondString.Length; j++)
                {
                    if (wordsFirstString[i] == wordsSecondString[j])
                    {
                        wordsCount++;
                    }
                }
                Console.WriteLine(wordsFirstString[i] + " - " + wordsCount);
            }
        }
    }
}