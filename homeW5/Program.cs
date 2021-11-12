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
            Regex r = new Regex(@"^\+\d\d\-\d\d\d\-\d\d\d\-\d\d\d");  
            string[] str = { "+35-392-022-194", "+958 28492-503" };  
            foreach (string s in str)  
            {  
                Console.WriteLine("{0} {1} a valid mobile number.", s,  
                r.IsMatch(s) ? "is" : "is not");  
            }




            string givenString = "Use Of Technology";  
            string[] Str = Regex.Split(givenString, @"\s+");
            Regex R = new Regex(@"\A[A-Z]");
            Console.WriteLine($"Checked whether or not each word in '{givenString}' strats with capital letter:");
            
            foreach (string s in Str)
            {
                if (R.IsMatch(s))
            Console.WriteLine("True");
                else
            Console.WriteLine("False");
            }
        
            // Alternative  NOT WORKING
            /*string pattern = @"(b[A-Z]\w*\s*)=$";
            string text = "Use Of Technology";
            MatchCollection matches;
            Regex defaultRegex = new Regex(pattern);
            matches = defaultRegex.Matches(text);
            Console.WriteLine("Checking whether all words start with capital letters in: " + text);
            if (defaultRegex.IsMatch(text))
            Console.WriteLine("true");
            else
            Console.WriteLine("not true");*/
        }
    }
}
