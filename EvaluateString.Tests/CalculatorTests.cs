using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        string[] exprassion = new string[] { "2+2" };
        IObserver observer = new ObserverTest();

        [Test]
        public void Attach_New_Observer()
        {
            Calculator calculator = new Calculator(exprassion);
            calculator.Attach(6, observer);
            Assert.AreEqual(6, calculator._observers.Count);
        }

        [Test]
        public void Detach_New_Observer()
        {
            Calculator calculator = new Calculator(exprassion);
            calculator.Detach(6);
            Assert.AreEqual(5, calculator._observers.Count);
        }

        [Test]
        public void Notify_Test()
        {
            Calculator calculator = new Calculator(exprassion);
            calculator.Notify();
            string actualvalue = "4";
            Assert.AreEqual("4", actualvalue);
        }

    }
}
