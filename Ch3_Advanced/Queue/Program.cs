using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> myQ = new Queue<string>();

            // Add items to the end of the queue
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");

            // use the count property to see how many items there are
            Console.WriteLine(myQ.Count);

            // Queues can be iterated without changing the structure
            foreach (string s in myQ)
            {
                Console.WriteLine(s);
            }

            // peek at the front of the queue
            Console.WriteLine(myQ.Peek());

            // remove items from the front of the queue
            myQ.Dequeue();

            // see if the queue contains an item
            Console.WriteLine(myQ.Contains("one"));

            // Remove all the items
            myQ.Clear();
            Console.WriteLine(myQ.Count);
        }
    }
}
