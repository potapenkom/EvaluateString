using NUnit.Framework;

namespace EvaluateString.Tests
{
    [TestFixture]
    public class BracketsObserverTests
    {
        string refvalueOne = "(2+2)*5";
        string refvalueTwo = "((4-2)*(3+3))/2";

        [Test]
        public void Brackets_With_refvalueOne()
        {
            BracketsObserver brackets = new BracketsObserver();
            brackets.PerformAction(ref refvalueOne);
            string actualvalue = refvalueOne;
            Assert.AreEqual("4*5", actualvalue);
        }

        [Test]
        public void Brackets_With_refvalueTwo()
        {
            BracketsObserver brackets = new BracketsObserver();
            brackets.PerformAction(ref refvalueTwo);
            string actualvalue = refvalueTwo;
            Assert.AreEqual("12/2", actualvalue);
        }

    }
}