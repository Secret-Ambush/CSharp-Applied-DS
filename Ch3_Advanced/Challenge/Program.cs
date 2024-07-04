// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TestStatements = {
                "print('Hello World')",
                "if a(b[x]) == b(a[x])",
                "function t(x) { print('t(x)')}",
                "print 'Hello World')",
                "f(x) = g(x[2)",
                "{{[[(())]]}",
                "}"
            };

            foreach (string TestStr in TestStatements)
            {
                bool Result = CheckBalanced(TestStr);

                Console.WriteLine($"Statement '{TestStr}' {(Result ? "is" : "is not")} balanced.");
            }
        }

        // TODO: Implement the CheckBalanced method
        static bool CheckBalanced(string TestStatement)
        {
            Stack<char> balance = new Stack<char>();

            foreach (char ch in TestStatement)
            {
                if (ch == '{' || ch == '(' || ch == '[')
                {
                    balance.Push(ch);
                }
                else if (ch == '}' || ch == ')' || ch == ']')
                {
                    if (balance.Count == 0) // If stack is empty
                        return false;

                    char last = balance.Pop();

                    if ((ch == '}' && last != '{') ||
                        (ch == ')' && last != '(') ||
                        (ch == ']' && last != '['))
                    {
                        return false;
                    }
                }
            }

            // Stack should be empty if all opening brackets have been properly closed.
            return balance.Count == 0;
        }
    }
}
