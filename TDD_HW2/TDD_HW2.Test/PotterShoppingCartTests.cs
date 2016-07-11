using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HW2.Extension;

namespace TDD_HW2.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void Buy_One_Firt_Should_Return_100()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
            };
            var expect = 100;
            // act
            var actual = target.CaculatePrice(x => x.BookName);

            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Buy_One_Firt_And_One_Second_Should_Return_200()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
               new Book() { BookName = HarryPotter.Second, Nums = 1},
            };
            var expect = 200;
            // act
            var actual = target.CaculatePrice(x => x.BookName);

            // assert
            Assert.AreEqual(expect, actual);
        }
    }

    internal enum HarryPotter
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
    }
    internal class Book
    {
        internal HarryPotter BookName { get; set; }
        internal int Nums { get; set; }
    }
}

