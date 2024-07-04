using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileType = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileType.Add(".bmp", "Bitmap File");
            fileType.Add(".txt", "Text File");
            fileType.Add(".pdf", "PDF File");
            fileType.Add(".html", "Webpage File");

            // use the Count property to see how many items there are
            Console.WriteLine(fileType.Count);


            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");


            // The TryAdd function makes it convenient to see if there's a duplicate
            bool added = fileType.TryAdd(".txt", "plain text");

            // Dictionaries are also like associative arrays
            Console.WriteLine($"Key value: {fileType[".html"]}");

            // This way, setting an existing key just overwrites the value
            fileType[".html"] = "Webpage";
            Console.WriteLine($"Key value: {fileType[".html"]}");

            // See if the Dictionary contains an key or a value
            Console.WriteLine($"Contains key: {fileType.ContainsKey(".html")}");
            Console.WriteLine($"Contains key: {fileType.ContainsValue("Webpage")}");

            // Remove items by key
            fileType.Remove(".html");
        }
    }
}
