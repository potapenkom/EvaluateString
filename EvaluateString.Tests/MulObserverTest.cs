using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class MulObserverTest
    {
        string refvalueOne = "10*5";
        string refvalueTwo = "100*2";

        [Test]
        public void MulObserver_With_refvalueOne()
        {
            MulObserver mul = new MulObserver();
            mul.PerformAction(ref refvalueOne);
            string actualvalue = refvalueOne;
            Assert.AreEqual("50", actualvalue);
        }

        [Test]
        public void MulObserver_With_refvalueTwo()
        {
            MulObserver mul = new MulObserver();
            mul.PerformAction(ref refvalueTwo);
            string actualvalue = refvalueTwo;
            Assert.AreEqual("200", actualvalue);
        }
    }
}
