using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvaluateString
{
    public class SubToSumObserver : IObserver
    {
        public void PerformAction(ref string expression)
        {
            Regex regex = new Regex(@"-\d*\.?\d*", RegexOptions.IgnorePatternWhitespace);
            foreach (Match match in regex.Matches(expression))
            {
                expression = expression.Replace(match.Value, $"+{match.Value}");
            }
        }
    }
}
