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
           
            string[] str = Regex.Split(givenString, @"\s+");
           
            Regex r = new Regex(@"\A[A-Z]");
           
            foreach (string s in str)
            {
                if (r.IsMatch(s))
           
            Console.WriteLine("True");
           
                else
            Console.WriteLine("False");
            }
        
            // Alternative
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
