using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checkout_Logic;

namespace Checkout_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NoItemsBrought()
        {
            Checkout checkout = new Checkout();

            int expected = 0;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedOneItemA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");

            int expected = 50;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedTwoItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 100;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedThreeItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 130;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }
    }
}
