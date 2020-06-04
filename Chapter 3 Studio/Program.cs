using System;
using System.Collections.Generic;

namespace Chapter_3_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine().ToLower();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char character in text)
            {
                if (Char.IsLetter(character))
                {
                    if (charCount.ContainsKey(character)) 
                    {
                        charCount[character] += 1;
                    }
                    else      
                    {
                        charCount.Add(character, 1);

                    }
                }
            }
            foreach (KeyValuePair<char, int> count in charCount)
            {
             Console.WriteLine($"{count.Key} : {count.Value}");
            }
        }
    }
}
