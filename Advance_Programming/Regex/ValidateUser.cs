using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex2
{
    internal class ValidateUser
    {
        public static bool IsValidUsername(String name)
        {
            string pattern = @"^[a-zA-Z][a-zA-z0-9]{4-14}";
            return Regex.IsMatch(name, pattern);
        }
    }
}
