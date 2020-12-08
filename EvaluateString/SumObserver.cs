using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvaluateString
{
    public class SumObserver : IObserver
    {
        public void PerformAction(ref string expression)
        {
            Regex regex = new Regex(@"-?\d+\+-?\d*\,?\d*", RegexOptions.IgnorePatternWhitespace);
            while (regex.IsMatch(expression))
            {
                foreach (Match match in regex.Matches(expression))
                {
                    var result = match.Value.Split('+');
                    var replace = Int32.Parse(result[0]) + Int32.Parse(result[1]);
                    expression = expression.Replace(match.Value, replace.ToString());
                }
            }
        }
    }
}
