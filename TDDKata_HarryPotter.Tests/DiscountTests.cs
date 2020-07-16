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
        public void ShouldAccessTheDiscounter()
        {           
            var expectedTotal = 0m;
            var basket = new Basket();

            Assert.Equal(Discounter.CalculateTotal(basket), expectedTotal);
        }

        [Fact]
        public void ShouldCalculateDiscountForTwoUniqueBooks()
        {
            var basket = new Basket();
            basket.Items.Add(new Book { Isbn = "0-7475-3269-9", Price = 8.0m, Title = "Philosopher's Stone" });
            basket.Items.Add(new Book { Isbn = "0-7475-3849-2", Price = 8.0m, Title = "Chamber of Secrets" });
            var expectedTotal = 15.2m;

            var total = Discounter.CalculateTotal(basket);

            Assert.Equal(total, expectedTotal);
        }
    }
}
