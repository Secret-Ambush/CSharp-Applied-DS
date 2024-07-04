using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an empty stack
            Stack<string> myStack = new Stack<string>(10);

            // TODO: The Push function pushes new elements onto the stack
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");

            // TODO: The Count property indicates how many elements are on the stack
            Console.WriteLine($"Item count: {myStack.Count}");

            // TODO: Stacks can be enumerated in place without changing the content
            foreach (string s in myStack)
            {
                Console.WriteLine(s);
            }


            // TODO: The Peek function examines the current top element but does not remove it
            string top = myStack.Peek();

            // TODO: The Pop function removes an element from the top
            string rem = myStack.Pop();

            // TODO: Search for an element using Contains
            Console.WriteLine(myStack.Contains("two"));
        }
    }
}
