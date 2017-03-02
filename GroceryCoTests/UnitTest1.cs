using System;
using NUnit.Framework;
using 

namespace GroceryCoTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int y = 7;
            int x = 7;
            Assert.AreEqual(x,y);
        }
    }
}
