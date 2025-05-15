using System;
using System.Collections.Generic;

class Result
{
    public static string pangrams(string s)
    {
        HashSet<char> letters = new HashSet<char>();

        foreach (char c in s.ToLower())
        {
            if (c >= 'a' && c <= 'z')
            {
                letters.Add(c);
            }
        }

        return letters.Count == 26 ? "pangram" : "not pangram";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = Result.pangrams(s);
        Console.WriteLine(result);
    }
}
