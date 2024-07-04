using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictExample
{
    class Program
    {

        /// IMPORTANT
        /// ORDERED DICTIONARIES will maintain 
        /// in which items are added

        static void Main(string[] args)
        {
            // Create a new OrderedDictionary object
            OrderedDictionary mod = new OrderedDictionary();

            // TODO: Add some keys and values in a particular order
            mod.Add("item1", "value1");
            mod.Add("item2", "value2");
            mod.Add("item3", "value3");
            mod.Add("item4", "value4");

            // TODO: Print the contents of the Dictionary
            PrintDictionary(mod);

            // TODO: Remove an existing item and add a new one
            mod.Remove("item3");
            mod.Add("item5", "value5");

            // TODO: Modify the value of an item in the dict
            mod["item2"] = "new value 2";


            // TODO: Add one final new item
            mod.Add("item6", "value 6");



        }

        static void PrintDictionary(OrderedDictionary theDict)
        {
            foreach (DictionaryEntry entry in theDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("---------------");
        }
    }
}
