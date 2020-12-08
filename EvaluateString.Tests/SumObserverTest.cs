using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class SumObserverTest
    {
        string refvalueOne = "2+1";
        string refvalueTwo = "5+2";

        [Test]
        public void SumObserver_With_refvalueOne()
        {
            SumObserver sum = new SumObserver();
            sum.PerformAction(ref refvalueOne);
            string actualvalue = refvalueOne;
            Assert.AreEqual("3", actualvalue);
        }

        [Test]
        public void SumObserver_With_refvalueTwo()
        {
            SumObserver sum = new SumObserver();
            sum.PerformAction(ref refvalueTwo);
            string actualvalue = refvalueTwo;
            Assert.AreEqual("7", actualvalue);
        }

    }
}
