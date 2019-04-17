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

        [TestMethod]
        public void ScannedFourItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 180;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedFiveItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 230;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedSixItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 260;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedSevenItemsA()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            int expected = 310;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedOneItemB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("B");

            int expected = 30;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedOneItemA_OneItemB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("B");

            int expected = 80;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedTwoItemsB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");

            int expected = 45;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedThreeItemsB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");

            int expected = 75;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedFourItemsB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");

            int expected = 90;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedFiveItemsB()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");

            int expected = 120;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedOneItemC()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("C");

            int expected = 20;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedTwoItemsC()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("C");

            int expected = 40;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedThreeItemsC()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");

            int expected = 60;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedFourItemsC()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");

            int expected = 80;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedOneItemD()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("D");

            int expected = 15;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedTwoItemsD()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("D");
            checkout.Scan("D");

            int expected = 30;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedThreeItemsD()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");

            int expected = 45;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScannedFourItemsD()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");

            int expected = 60;

            int actual = checkout.GetTotalPrice();

            Assert.AreEqual(expected, actual);
        }
    }
}
