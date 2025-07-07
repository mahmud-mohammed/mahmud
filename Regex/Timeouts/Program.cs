// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Using Timeout settings for RegEx in .NET

using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const int MAX_REGEX_TIME = 2000; // Timeout in milliseconds

        // Use a Stopwatch to show elapsed time
        Stopwatch sw;

        // TODO: Use a Timeout value when executing RegEx to guard against bad input
        TimeSpan Timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

        // Run the expression and output the result
        try
        {
            sw = Stopwatch.StartNew();

            Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, Timeout);
            MatchCollection mc = CapWords.Matches(thestr);

            sw.Stop();
            Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");

            foreach (Match match in mc)
            {
                Console.WriteLine($"'{match.Value}' found at position {match.Index}");
            }
        }
        catch (RegexMatchTimeoutException e)
        {
            Console.WriteLine($"The Regex took too long to execute! Timeout: {e.MatchTimeout}");
        }
    }
}
