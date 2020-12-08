using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
    public class ConsoleRepository : IRepository
    {
        string _expression;

        public ConsoleRepository(string expration)
        {
            _expression = expration;
        }

        public string[] GetData()
        {
            return _expression.Split("");
        }

        public void SetData(string[] result)
        {
            if (Validator.Valid(result[0]))
            {
                Console.WriteLine($"{_expression} = {result[0].ToString()}");
            }
            else
            {
                Console.WriteLine($"{_expression} = error in expression");
            }
        }

    }
}
