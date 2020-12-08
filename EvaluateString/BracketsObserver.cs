using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EvaluateString
{
    public class BracketsObserver : IObserver
    {
        public void PerformAction(ref string expression)
        {
            Regex regex = new Regex(@"\([\w\.\-\^\*\+\/]+\)", RegexOptions.IgnorePatternWhitespace);
            while (regex.IsMatch(expression))
            {
                foreach (Match match in regex.Matches(expression))
                {
                    string exp = match.Value;
                    string filtered = exp.Replace("(", "").Replace(")", "");
                    string[] replace = new string[] { filtered };
                    Calculator calculator = new Calculator(replace);
                    replace = calculator.Notify();
                    expression = expression.Replace(match.Value, replace[0].ToString());
                }
            }
        }
    }
}
