using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int lonelyinteger(List<int> a)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        // Print the list 'a'
        Console.WriteLine("List a:");
        Console.WriteLine(string.Join(", ", a));

        // Print the HashSet 'seenNumbers'
        Console.WriteLine("HashSet seenNumbers:");
        Console.WriteLine(string.Join(", ", seenNumbers));

        foreach (int num in a)
        {
            if (seenNumbers.Contains(num))
            {
                seenNumbers.Remove(num);
            }
            else
            {
                seenNumbers.Add(num);
            }
        }

        return seenNumbers.First();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string? outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (string.IsNullOrEmpty(outputPath))
        {
            outputPath = "default_output.txt";  // Use a default path if the environment variable is not set
        }

        TextWriter textWriter = new StreamWriter(outputPath, true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
