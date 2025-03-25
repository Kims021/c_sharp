using System;
using System.IO;

class Result
{
    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        // Perform a bitwise NOT and mask to keep only the last 32 bits.
        return n ^ 0xFFFFFFFF;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Get the output path from environment variables.
        string outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");

        // If the environment variable is null, fall back to writing to the console.
        TextWriter textWriter = outputPath != null 
            ? new StreamWriter(outputPath, true) 
            : Console.Out;

        // Read the number of test cases
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        // Process each test case
        for (int qItr = 0; qItr < q; qItr++)
        {
            // Read the number for which we need to flip the bits
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            // Get the result by calling the flippingBits function
            long result = Result.flippingBits(n);

            // Write the result to output
            textWriter.WriteLine(result);
        }

        // If using a file stream, flush and close it
        if (textWriter != Console.Out)
        {
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
