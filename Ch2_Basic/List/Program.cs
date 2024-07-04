using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};
            // TODO: Create the list
            List<string> strList = new List<string>(10);

            // TODO: Add some elements to the list from an existing array
            strList.AddRange(comedians);

            // TODO: Add individual items
            strList.Add("Rebecca");

            // TODO: Examine the Count and Capacity
            //Console.WriteLine($"Count: {strList.Count}, Capacity: {strList.Capacity}");

            // TODO: Enumerate the items in the list with a foreach loop
            //PrintList(strList);

            // TODO: Access any item by its index
            //Console.WriteLine($"Item value: {strList[4]}");

            // TODO: Remove items from the list
            strList.Remove("Rebecca");
            strList.RemoveAt(3);

            // TODO: Sort the list content
            strList.Sort();
            //PrintList(strList);

            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(strList.Contains("Bruce"));

            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            strList.Exists(x => x.Length > 14);

            // TODO: Use the Find function to search through items
            string item ="";
            item = strList.Find(x => x.StartsWith("L"));


            // TODO: The FindAll function can find multiple items
            List<string> item2 = strList.FindAll(x => x.StartsWith("L"));

            // TODO: Use TrueForAll to see if a given condition is true for all elements
            Console.WriteLine(strList.TrueForAll(x => x.Length > 10));
        }

        static void PrintList(List<string> theList)
        {
            foreach (string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
