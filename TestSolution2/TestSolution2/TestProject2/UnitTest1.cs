using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestProject2
{
    [TestFixture]
    public class UnitTest1
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
