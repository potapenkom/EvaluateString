using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class ConsoleRepositoryTests 
    {
        public string expression = "2+2";
        string[] resultOne = new string[] { "4" };
        string[] resultTwo = new string[] { "Some result" };

        [Test]
        public void Get_Data_With_Expration()
        {
            ConsoleRepository repository = new ConsoleRepository(expression);
            string[] actual = expression.Split("");
            Assert.AreEqual(actual, repository.GetData());
        }

        [Test]
        public void Set_Data_With_Expration()
        {
            ConsoleRepository repository = new ConsoleRepository(expression);
            string actualOne = $"{expression} = {resultOne[0].ToString()}";
            string actualTwo = $"{expression} = error in expression";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                repository.SetData(resultOne);
                var result = sw.ToString().Trim();
                Assert.AreEqual(actualOne, result);
            }

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                repository.SetData(resultTwo);
                var result = sw.ToString().Trim();
                Assert.AreEqual(actualTwo, result);
            }
        }
    }
}
