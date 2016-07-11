using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW2.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void Buy_Firt_And_Second_Should_Return_200()
        {
            // arrange
            var orders = new List<HarryPotter>()
            {
                HarryPotter.First,
                HarryPotter.Second,
                //HarryPotter.First,
            };
            var expect = 200;

            // act
            var target = new PotterShoppingCart<HarryPotter>();
            var actual = target.GetPrice(orders);

            // assert
            Assert.AreEqual(expect, actual);
        }
    }
}

