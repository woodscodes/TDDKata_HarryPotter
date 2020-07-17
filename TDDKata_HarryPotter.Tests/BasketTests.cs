using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata_HarryPotter.Core.Models;
using Xunit;

namespace TDDKata_HarryPotter.Tests
{
    public class BasketTests
    {
        [Fact]
        public void ShouldAddBooksToBasket()
        {
            var basket = new Basket();
            basket.Items.Add(new Book { Volume = 1, Price = 8.0m });
            basket.Items.Add(new Book { Volume = 1, Price = 8.0m });
            var expectedBasketCount = 2;

            Assert.Equal(basket.Items.Count, expectedBasketCount);           
        }

    }
}
