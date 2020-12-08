using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvaluateString
{
    public class DivToMultiObserver : IObserver
    {
        public void PerformAction(ref string expression)
        {
            Regex regex = new Regex(@"\/\d*\.?\d*", RegexOptions.IgnorePatternWhitespace);
            foreach (Match match in regex.Matches(expression))
            {
                var result = match.Value.Replace("/", "");
                var replace = 1 / Double.Parse(result);
                expression = expression.Replace(match.Value, $"*{replace}");
            }
        }

    }
}
