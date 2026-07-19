using System;
using System.Collections.Generic;
namespace Program3
{
    public class  FrequencyCounter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No sentence entered.");
                return;
            }
            Dictionary<string, int> wordfrequency = new Dictionary<string, int>();
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(String word in words)
            {
                string cleanWord = word.Trim('.', ',', ';', ':', '!', '?', '"', '\'', '(', ')').ToLower();
                if(cleanWord == "")
                {
                    continue;
                }
                if(wordfrequency.ContainsKey(cleanWord) ) {
                    wordfrequency[cleanWord]++;
                }
                else {
                    wordfrequency[cleanWord] = 1;
                }
            }
            Console.WriteLine("\nWord Frequency:");

            foreach (KeyValuePair<string, int> item in wordfrequency)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}