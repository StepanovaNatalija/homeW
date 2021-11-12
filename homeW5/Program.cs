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
            Console.WriteLine($"Checking word by word, whether or not each word in '{givenString}' strats with capital letter:");
            List<string> TrueOrFalse = new();

            foreach (string s in Str)
            {
                if (R.IsMatch(s))
                {
                    Console.WriteLine($"{s} - True");
                    TrueOrFalse.Add("True");
                }                
            }

            foreach (string s in Str)
            {
                if (!R.IsMatch(s))
                {
                    Console.WriteLine($"{s} - False");
                    TrueOrFalse.Add("False");
                }
            }
            
            Console.WriteLine(TrueOrFalse.All(item => item == "True") ?
                "So, as you see, all words start with Capital letter!" :
                "So, as you see, not all words start with Capital letter!");



            // Below code for checking for any capital letter character in a given string
            string u = "use of tecHnology";
            Console.WriteLine($"Checking for any capital letter in text '{u}'. Are there any?");
            Console.WriteLine(checkStringForUpperCase(u));

        }
        public static bool checkStringForUpperCase(string u)
        {
            for (int i = 0; i < u.Length; i++)
            {
                if (char.IsUpper(u[i]))
                    return true;
            }
            return false;
        }
    }
}

