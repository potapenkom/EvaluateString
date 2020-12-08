using System;

namespace EvaluateString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expression");
            string expression = Console.ReadLine();
            IRepository repository = RepositoryFactory.CreateRepository(expression);
            СonnectionService сonnection = new СonnectionService(repository);
            сonnection.Process();
        }
    }
}
