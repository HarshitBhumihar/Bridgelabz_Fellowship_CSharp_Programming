//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Regex9
//{
//    internal class ExtractLink
//    {
//        static void Main(string[] args)
//        {
//            string text = "Visit our website at https://www.example.com or http://www.test.com for more information.";
//            string pattern = @"https?://[^\s]+";
//            MatchCollection m = Regex.Matches(text, pattern);
//            foreach (Match m2 in m)
//            {
//                Console.WriteLine(m2.Value);
//            }
//        }
//    }
//}
