using System;
using System.Collections.Specialized;

namespace StrCollectionExample
{

    /// This is quite old and is now replace with List<string>
    class Program
    {
        static void Main(string[] args)
        {
            // define an initial set of strings
            string[] colors = { "red", "orange", "yellow", "green", "blue", "violet" };

            // TODO: create the string collection
            StringCollection strcoll = new StringCollection();

            // TODO: Add an existing set of strings
            strcoll.AddRange(colors);


            // TODO: add some individual items
            strcoll.Add("Forest green");
            strcoll.Insert(3, "Cyan");

            // TODO: Use the Count property to see how many there are
            Console.WriteLine(strcoll.Count);

            // TODO: Iterate over each string in the collection
            foreach (string s in strcoll)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("___________________");

            // TODO: Access an individual item
            Console.WriteLine(strcoll[3]);

            // TODO: Search for a string
            Console.WriteLine(strcoll.Contains("blue"));

            // TODO: Clear all the contents
            strcoll.Clear();
        }
    }
}
