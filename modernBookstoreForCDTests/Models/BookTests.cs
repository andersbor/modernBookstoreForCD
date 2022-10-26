using Microsoft.VisualStudio.TestTools.UnitTesting;
using modernBookstoreForCD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modernBookstoreForCD.Models.Tests
{
    [TestClass()]
    public class BookTests
    {
        private Book bookGood = new() { Id = 1, Title = "Good Title", Price = 10 };
        private Book bookTitleNull = new() { Id = 2, Title = null, Price = 10 };
        private Book bookTitleTooShort = new() { Id = 3, Title = "A", Price = 10 };
        private Book bookPriceNegative = new() { Id = 4, Title = "Good Title", Price = -1 };

        [TestMethod()]
        public void ToStringTest()
        {
            string str = bookGood.ToString();
            Assert.AreEqual("Id: 1, Title: Good Title, Price: 10", str);
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateTitleTest()
        {
            bookGood.ValidateTitle();
            Assert.ThrowsException<ArgumentNullException>(() => bookTitleNull.ValidateTitle());
            Assert.ThrowsException<ArgumentException>(() => bookTitleTooShort.ValidateTitle());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            bookGood.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bookPriceNegative.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            bookGood.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => bookTitleNull.Validate());
            Assert.ThrowsException<ArgumentException>(() => bookTitleTooShort.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bookPriceNegative.Validate());
        }
    }
}