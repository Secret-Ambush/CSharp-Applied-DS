using System;
using System.Collections;
using System.Collections.Specialized;

namespace HybridDictExample
{
    class Program
    {
        static void Main(string[] args)
        {

            /// IMPORTANT
            /// with REGULAR DICTIONARIES, there is NO guarantee that the collection
            /// will maintain the order in which items are added



            // TODO: Create the hybrid dictionary
            HybridDictionary myHBD = new HybridDictionary(20, false);


            // TODO: Add some initial items
            myHBD.Add("item1", "value 1");
            myHBD.Add("item2", "value 2");
            myHBD.Add("item3", "value 3");
            myHBD.Add("item4", "value 4");

            foreach (DictionaryEntry e in myHBD)
            {
                Console.WriteLine($"{e.Key}, {e.Value}");
            }

            Console.WriteLine(myHBD.Count);

            // TODO: Contains
            Console.WriteLine(myHBD.Contains("item2"));

            // TODO: Remove
            myHBD.Remove("item2");
            foreach (DictionaryEntry e in myHBD)
            {
                Console.WriteLine($"{e.Key}, {e.Value}");
            }

            // TODO: Clear
            myHBD.Clear();

            // TODO: Print the number of items
            Console.WriteLine(myHBD.Count);



        }
    }
}
