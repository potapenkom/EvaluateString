using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class DivToMultiObstrverTest
    {
        string refvalueOne = "10/5";
        string refvalueTwo = "10*2/5";

        [Test]
        public void DivToMulti_With_refvalueOne()
        {
            DivToMultiObserver div = new DivToMultiObserver();
            div.PerformAction(ref refvalueOne);
            string actualvalue = refvalueOne;
            Assert.AreEqual("10*0,2", actualvalue);
        }

        [Test]
        public void DivToMulti_With_refvalueTwo()
        {
            DivToMultiObserver div = new DivToMultiObserver();
            div.PerformAction(ref refvalueTwo);
            string actualvalue = refvalueTwo;
            Assert.AreEqual("10*2*0,2", actualvalue);
        }

    }
}
