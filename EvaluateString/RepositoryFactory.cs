using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EvaluateString
{
    public class RepositoryFactory
    {
        public static IRepository CreateRepository(string expression)
        {
            IRepository repository = null;
            if (File.Exists(expression))
            {
                return repository = new FileRepository(expression);
            }
            else
            {
                return repository = new ConsoleRepository(expression);
            }
        }
    }
}
