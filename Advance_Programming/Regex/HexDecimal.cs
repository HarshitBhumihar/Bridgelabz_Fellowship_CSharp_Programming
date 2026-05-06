using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex4
{
    internal class HexDecimal
    {
        public static bool hexdecimal(String hex)
        {
            string pattern = @"^#[0-9a-zA-Z]{6}";
            return Regex.IsMatch(hex, pattern);
        }
    }
}
