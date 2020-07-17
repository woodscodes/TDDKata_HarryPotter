using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata_HarryPotter.Core.Models;
using Xunit;

namespace TDDKata_HarryPotter.Tests
{
    public class DiscountTests
    {
        [Fact]
        public void ShouldGiveZeroOnZeroBooks()
        {
            Assert.Equal(0, Discounter.Price());
        }

        [Fact]
        public void ShouldBeEightForOneBook()
        {
            Assert.Equal(8, Discounter.Price(1));
        }

        [Fact]
        public void ShouldBeSixteenForTwoBooks()
        {
            Assert.Equal(8 * 2, Discounter.Price(1, 1));
        }

        [Fact]
        public void ShouldBe24ForThreeBooks()
        {
            Assert.Equal(8 * 3, Discounter.Price(0, 0, 0));
        }

        [Fact]
        public void ShouldBe40ForFiveBooks()
        {
            Assert.Equal(8 * 5, Discounter.Price(5, 5, 5, 5, 5));
        }

        [Fact]
        public void ShouldGive5DiscountOnTwoTheSame()
        {
            Assert.Equal((8 * 2) * 0.95m, Discounter.Price(2, 1));
        }
    }
}
