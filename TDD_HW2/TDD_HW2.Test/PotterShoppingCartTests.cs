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
        public void Buy_One_Firt_And_One_Second_Should_Return_190()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
               new Book() { BookName = HarryPotter.Second, Nums = 1},
            };
            var expect = 190;
            // act
            var actual = target.CaculatePrice(x => x.BookName);

            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Buy_One_For_Firt_Second_And_Third_Should_Return_270()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
               new Book() { BookName = HarryPotter.Second, Nums = 1},
               new Book() { BookName = HarryPotter.Third, Nums = 1},
            };
            var expect = 270;
            // act
            var actual = target.CaculatePrice(x => x.BookName);

            // assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void Buy_One_For_Firt_Second_Third_And_Fourth_Should_Return_320()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
               new Book() { BookName = HarryPotter.Second, Nums = 1},
               new Book() { BookName = HarryPotter.Third, Nums = 1},
               new Book() { BookName = HarryPotter.Fourth, Nums = 1},
            };
            var expect = 320;
            // act
            var actual = target.CaculatePrice(x => x.BookName);

            // assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void Buy_Each_Eposide_For_One_Should_Return_375()
        {
            // arrange
            var target = new List<Book>()
            {
               new Book() { BookName = HarryPotter.First, Nums = 1},
               new Book() { BookName = HarryPotter.Second, Nums = 1},
               new Book() { BookName = HarryPotter.Third, Nums = 1},
               new Book() { BookName = HarryPotter.Fourth, Nums = 1},
                new Book() { BookName = HarryPotter.Fifth, Nums = 1},
            };
            var expect = 375;
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

