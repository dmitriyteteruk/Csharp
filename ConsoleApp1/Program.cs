// C# program to Convert a string 
// to a Character array 
// using Naive Approach 

using System;

public class GFG
{

    static public void Main()
    {
        string str = "TestString";

        // Creating array of string length 
        char[] ch = new char[str.Length];

        // Copy character by character into array 
        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = str[i];
        }

        // Printing content of array 
        foreach (char c in ch)
        {
            Console.WriteLine(c);
        }
    }
}