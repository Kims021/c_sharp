using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();

        // For each query, count its occurrences in the strings list
        foreach (string query in queries)
        {
            int count = 0;

            // Count how many times 'query' appears in the 'strings' list
            foreach (string str in strings)
            {
                if (str == query)
                {
                    count++;
                }
            }

            // Add the count to the result list
            result.Add(count);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Get OUTPUT_PATH environment variable or use default if not set
        string? outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (string.IsNullOrEmpty(outputPath))
        {
            outputPath = "default_output.txt";  // Provide a default path
        }

        // Open StreamWriter to write to the file
        TextWriter textWriter = new StreamWriter(outputPath!, true); // Use '!' to suppress the warning

        // Reading the number of strings
        int stringsCount = Convert.ToInt32(Console.ReadLine()?.Trim());
        List<string> strings = new List<string>();

        // Reading each string into the strings list
      // Reading each string into the strings list
        for (int i = 0; i < stringsCount; i++)
        {
            string? stringsItem = Console.ReadLine(); // Mark as nullable
            if (stringsItem != null)
            {
                strings.Add(stringsItem); // Only add if not null
            }
        }


        Console.WriteLine(strings);
        // Reading the number of queries
        int queriesCount = Convert.ToInt32(Console.ReadLine()?.Trim());
        List<string> queries = new List<string>();

        // Reading each query into the queries list
        for (int i = 0; i < queriesCount; i++)
        {
            string? queriesItem = Console.ReadLine(); // Mark as nullable
            if (queriesItem != null)
            {
                queries.Add(queriesItem); // Only add if not null
            }
        }

        // Get the result from matchingStrings function
        List<int> res = Result.matchingStrings(strings, queries);

        // Write the result as a newline-separated string to the file or console
        textWriter.WriteLine(String.Join("\n", res));

        // Flush and close the StreamWriter
        textWriter.Flush();
        textWriter.Close();

        // Optionally, print the result to the console
        Console.WriteLine("Results written to: " + outputPath);
        Console.WriteLine("Result: ");
        Console.WriteLine(String.Join("\n", res));  // Printing the result to the console as well
    }
}
