using System;

namespace ReverseAndCombineText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sdfsdf wee sdffg 342234 ftt";
            text = ReverseAndCombineText(text);
            Console.WriteLine(text);
        }

        static string ReverseAndCombineText(string text)
        {
            string[] words = text.Split(' ');
            string[] tempWords;

            while (words.Length > 1)
            {
                int length = words.Length;
                int index = 0;
                tempWords = (length % 2 == 0) ? new string[length / 2] : new string[length / 2 + 1];

                for (int tempIndex = 0; tempIndex < tempWords.Length; index += 2, tempIndex++)
                {
                    if (index == length - 1)
                    {
                        tempWords[tempIndex] = ReverseText(words[index]);
                    }
                    else
                    {
                        tempWords[tempIndex] = ReverseText(words[index]) + ReverseText(words[index + 1]);
                    }
                }
                words = tempWords;
            }

            return words[0];
        }

        static string ReverseText(string text)
        {
            char[] letters = text.ToCharArray();
            char temp;
            for (int i = 0, j = text.Length - 1; i < text.Length / 2; i++, j--)
            {
                temp = letters[i];
                letters[i] = letters[j];
                letters[j] = temp;
            }
            string reversedWord = new string(letters);
            return reversedWord;
        }
    }
}
