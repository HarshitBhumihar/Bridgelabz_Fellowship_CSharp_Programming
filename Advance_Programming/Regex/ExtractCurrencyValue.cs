using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex13 
{
    class ExtractCurrencyValue
    {
        static void Main(string[] args)
        {
            string text = "The total cost is $123.45 for the item.";
            string pattern = @"\$\d+(\.\d{2})?";
            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                Console.WriteLine("Extracted currency value: " + match.Value);
            }
        }
    }
}
