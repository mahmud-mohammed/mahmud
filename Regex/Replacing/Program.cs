
// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for Replacing content with Regexes

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string teststr1 = "The quick brown Fox jumps over the lazy Dog";

        Regex CapWords = new Regex(@"[A-Z]\w+");

        // TODO: Regular expressions can be used to replace content in strings
        // in addition to just searching for content
        string result = CapWords.Replace(teststr1, "***");
        Console.WriteLine(teststr1);
        Console.WriteLine(result);

        // TODO: Replacement text can be generated on the fly using MatchEvaluator
        // This is a delegate that computes the new value of the replacement
        string result2 = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper));
        Console.WriteLine(result2);
    }

    static string MakeUpper(Match m)
    {
        string s = m.ToString();
        if (m.Index == 0)
        {
            return s; // leave the first word unchanged
        }
        return s.ToUpper(); // convert subsequent capitalized words to uppercase
    }
}

