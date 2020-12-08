using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class ValidatorTest
    {
        string text = "Some text";
        string digit = "3";
        string negative = "-3";

        [Test]
        public void Valid_With_Text()
        {
            bool actual = Validator.Valid(text);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Valid_With_Digit()
        {
            bool actual = Validator.Valid(digit);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Valid_With_Negative()
        {
            bool actual = Validator.Valid(negative);
            Assert.AreEqual(true, actual);
        }

    }
}
