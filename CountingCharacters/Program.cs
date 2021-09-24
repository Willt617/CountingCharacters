using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "William Thompson";
            char[] charactersInString = test.ToCharArray();
            Console.WriteLine(charactersInString);

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char letter in charactersInString)
            {
                if (charCount.ContainsKey(letter))
                {
                    charCount[letter] += 1;
                }
                else
                {
                    charCount.Add(letter, 1);
                }
            }
            foreach(KeyValuePair<char,int> item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
