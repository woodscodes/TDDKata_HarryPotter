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
        public void ShouldBeZeroOnOneBook()
        {
            Assert.Equal(8, Discounter.Price(1));
        }
    }
}
