// Example file for C# Applied Data Structures by Joe Marini
// Using StringBuilder

using System;
using System.Text;

public sealed class App
{
    static void Main()
    {
        // TODO: Create a StringBuilder that expects to hold 50 characters.
        // Initialize the StringBuilder with "ABC".
        StringBuilder sb = new StringBuilder(50);
        Console.WriteLine($"Capacity: {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}");


        // TODO: Append three characters (D, E, and F) to the end of the StringBuilder.
        sb.Append(['D', 'E', 'J']);

        // TODO: Append a format string to the end of the StringBuilder.
        sb.AppendFormat("GHI {0} {1}", 'J', 'k');


        // TODO: Display the number of characters in the StringBuilder and its string.
        Console.WriteLine($"{sb.Length} chars, string: {sb.ToString()}");


        // TODO: Use AppendJoin to add an array of strings with a separator character
        sb.AppendJoin("-", new char[] { 'L', 'M', 'N' });

        // TODO: Insert a string at the beginning of the StringBuilder.
        sb.Insert(0, "Alphabet: ");


        // TODO: Replace all lowercase k's with uppercase K's.
        sb.Replace('k', 'K');

        // TODO: Display the number of characters in the StringBuilder and its string.
        Console.WriteLine($"Count: {sb.Length}, String: {sb.ToString()}");


    }
}

