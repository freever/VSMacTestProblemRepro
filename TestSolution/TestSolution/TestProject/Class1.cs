using System;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void SHOULD_PASS()
        {
            Assert.AreEqual(1,1);
        }

        [Test]
        public void SHOULD_FAIL()
        {
            Assert.AreEqual(1, 2);
        }
    }
}
