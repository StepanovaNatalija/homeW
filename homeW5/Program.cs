using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.String;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homeW5
{

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(b[A-Z]\w*\s*)=$";
            string text = "Use Of Technology";
            MatchCollection matches;

            Regex defaultRegex = new Regex(pattern);
            // Get matches of pattern in text
            matches = defaultRegex.Matches(text);
            Console.WriteLine("Checking whether all words start with capital letters in: " + text);
            if (defaultRegex.IsMatch(text))
            { Console.WriteLine(matches); }
        }
    }
}
