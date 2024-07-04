using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge
{
    class Program
    {
        static void PrintStringStats(string TheString)
        {
            // Split the string on space character boundary
            string[] wordArray = TheString.Split(new char[] { ' ', '\n', '\r' });

            // Count the total number of words
            List<string> words = new List<string>(wordArray);
            Console.WriteLine($"Total number of words: {words.Count}");

            // Find the longest word
            string maxword = "";
            foreach (string x in words)
            {
                if (maxword.Length < x.Length)
                {
                    maxword = x;
                }
            }
            Console.WriteLine($"Longest word: {maxword}");

            // Build the word count data
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Print out the word count data
            Console.WriteLine("Word counts:");
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        static void Main(string[] args)
        {
            string[] GettysburgAddress = {
                "Four score and seven years ago our",
                "fathers brought forth on this continent",
                "a new nation conceived in Liberty",
                "and dedicated to the proposition",
                "that all men are created equal",
                "Now we are engaged in a great civil war",
                "testing whether that nation",
                "or any nation so conceived and so dedicated",
                "can long endure",
                "We are met on a great battlefield of that war",
                "We have come to dedicate a portion of that field",
                "as a final resting place for those who",
                "here gave their lives that that nation might live",
                "It is altogether fitting",
                "and proper that we should do this"
            };

            // Convert the string array to a single string and call PrintStringStats
            string TheText = string.Join(" ", GettysburgAddress);
            PrintStringStats(TheText);
        }
    }
}
