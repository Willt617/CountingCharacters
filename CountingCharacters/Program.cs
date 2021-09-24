using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter Word Whose Letters You Would Like To Count!");
            string input = Console.ReadLine();
            characterCount(input);          
        }
        public static bool isAlphabetic(char c)
        {
            return (c >= 'a' && c <= 'z');
        }
        public static Dictionary<char,int> characterCount(string str)
        {
            char[] charactersInString = str.ToLower().ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char letter in charactersInString)
            {
                if (!isAlphabetic(letter))
                    continue;
                if (charCount.ContainsKey(letter))
                    charCount[letter] += 1;
                else
                    charCount.Add(letter, 1);
            }
            foreach (KeyValuePair<char, int> item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            return charCount;
        }
    }
}
