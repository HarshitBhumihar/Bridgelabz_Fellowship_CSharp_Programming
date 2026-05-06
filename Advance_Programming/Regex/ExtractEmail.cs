//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Regex6
//{
//    class ExtractEmail
//    {
//        static void Main(string[] args)
//        {
//            string name= "Contact us at support@example.com and info@company.org";
//            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
//            MatchCollection matches = Regex.Matches(name, pattern);
//            foreach(Match match in matches)
//            {
//                Console.WriteLine(match.Value);
//            }
            
//        }
//    }
//}
