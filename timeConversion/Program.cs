using System;
using System.IO;

class Result
{
    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        // Correctly parsing the 12-hour format with AM/PM
        DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", null);
        return dateTime.ToString("HH:mm:ss");  // Converting to 24-hour format
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Open StreamWriter to write to the file
        TextWriter textWriter = new StreamWriter("output.txt", true);

        // Reading input from the console
        string s = Console.ReadLine();

        // Call the timeConversion function
        string result = Result.timeConversion(s);

        // Write result to both stdout (console) and output.txt file
        Console.WriteLine(result);  // Output to console
        textWriter.WriteLine(result);  // Output to file

        // Flush and close the StreamWriter
        textWriter.Flush();
        textWriter.Close();
    }
}
