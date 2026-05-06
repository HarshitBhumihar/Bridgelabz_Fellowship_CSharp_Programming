//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Regex7
//{
//    class ExtractAllCapitalizedWords
//    {
//        public static void Main(String[] args)
//        {
//            string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
//            string pattern = @"\b[A-Z][a-z]*\b";
//            MatchCollection m = Regex.Matches(text, pattern);
//            foreach (Match match in m)
//            {
//                Console.WriteLine(match.Value);
//            }
//        }
//    }
//}
