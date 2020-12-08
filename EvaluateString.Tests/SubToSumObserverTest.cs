using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class SubToSumObserverTest
    {
        string refvalueOne = "10-5";
        string refvalueTwo = "10+2-5";

        [Test]
        public void SubToSum_With_refvalueOne()
        {
            SubToSumObserver sub = new SubToSumObserver();
            sub.PerformAction(ref refvalueOne);
            string actualvalue = refvalueOne;
            Assert.AreEqual("10+-5", actualvalue);
        }

        [Test]
        public void SubToSum_With_refvalueTwo()
        {
            SubToSumObserver sub = new SubToSumObserver();
            sub.PerformAction(ref refvalueTwo);
            string actualvalue = refvalueTwo;
            Assert.AreEqual("10+2+-5", actualvalue);
        }

    }
}
