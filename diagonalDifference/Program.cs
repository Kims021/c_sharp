using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        // Loop through the rows and calculate the sums
        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i]; // Primary diagonal: (i, i)
            secondaryDiagonalSum += arr[i][n - i - 1]; // Secondary diagonal: (i, n-i-1)
        }

        // Return the absolute difference between the sums
        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Get the output path from environment variables (with null-check)
        string? outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");

        // If the environment variable is null, fall back to writing to the console
        TextWriter textWriter = outputPath != null ? new StreamWriter(outputPath, true) : Console.Out;

        // Read size of the matrix
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Initialize a list of lists to store the matrix
        List<List<int>> arr = new List<List<int>>();

        // Read each row of the matrix
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        // Call the diagonalDifference function to get the result
        int result = Result.diagonalDifference(arr);

        // Write the result to the output path (or console)
        textWriter.WriteLine(result);

        // Flush and close if we are writing to a file
        if (textWriter != Console.Out)
        {
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
