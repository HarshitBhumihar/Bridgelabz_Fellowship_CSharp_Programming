using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex3
{
    internal class LicencePlateNumber
    {
        public static bool IsValidLicencePlateNumber(string licencePlateNumber)
        {
            string pattern = @"^[A-Z]{2}[0-9]{4}$";
            return Regex.IsMatch(licencePlateNumber, pattern);

        }
        }
}
