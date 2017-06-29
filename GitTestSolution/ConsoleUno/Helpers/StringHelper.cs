using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUno.Helpers
{
    class StringHelper
    {
        public static void PrintOnConsole(string text)
        {
            Console.WriteLine(text);
        }

        public static string GetWordFromSentence(string input, int index)
        {
            string[] inputWords = input.Split(' ');
            List<String> inputWordsList = inputWords.ToList();
            inputWordsList.RemoveAll(s=>s.Equals(' '));
            inputWordsList.ToArray();

            if (index < 0)
                index = 0;
            if (index > inputWords.Length-1)
                index--;

            return inputWordsList[index];
        }

    }
}
