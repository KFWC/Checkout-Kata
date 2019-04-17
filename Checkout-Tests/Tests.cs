using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checkout_Logic;

namespace Checkout_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestNoItemsBrought()
        {
            Checkout checkout = new Checkout();

            int expected = 0;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }
    }
}
