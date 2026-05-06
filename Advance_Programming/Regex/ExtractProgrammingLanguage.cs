//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Regex12
//{
//    class ExtractProgrammingLanguage
//    {
//        static void Main(string[] args)
//        {
//            string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
//            string pattern = @"\b(Java|Python|JavaScript|Go)\b";
//            MatchCollection m= Regex.Matches(text, pattern);
//            foreach (Match match in m)
//            {
//                Console.WriteLine(match.Value);
//            }
//        }
//    }
//}
