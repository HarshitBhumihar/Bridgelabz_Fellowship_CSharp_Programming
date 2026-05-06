//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;
//namespace Regex8
//{
//     class ExtractDate
//    {
//        static void Main(string[] args)
//        {
//            string text = "The event is scheduled for 2024-06-15 and the registration deadline is 2024-05-31.";
//            string pattern = @"\b\d{4}-\d{2}-\d{2}\b";
//            MatchCollection m = Regex.Matches(text, pattern);
//            foreach (Match m2 in m)
//            {
//                Console.WriteLine(m2.Value);
//            }
//        }
//    }
//}
