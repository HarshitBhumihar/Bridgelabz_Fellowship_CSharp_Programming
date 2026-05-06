using System;   
using System.Text.RegularExpressions;

namespace RegexExample
{
    internal class BasicSyntax
    {
        public static bool IsValidPhoneNumber(string phonenumber)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phonenumber, pattern);  
        }

    }
}



















