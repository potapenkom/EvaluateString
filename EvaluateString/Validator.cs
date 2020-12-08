using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvaluateString
{
    public static class Validator
    {
        public static bool Valid(string exprassion)
        {
            bool valid = Regex.IsMatch(exprassion, @"^-*[0-9,\.]+$") ? true : false;
            return valid;
        }
    }
}
