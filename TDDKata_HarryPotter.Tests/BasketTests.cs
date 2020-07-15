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
        public void ShouldAddABookToBasket()
        {
            var basket = new Basket();

            Assert.IsType<Basket>(basket);
        }

        [Fact]
        public void ShouldProvideANewList()
        {
            var basket = new Basket();
        }

        [Fact]
        public void ShouldAddABook()
        {
            var basket = new Basket();
            var book = new Book();
            var expectedNumberOfBooks = 1;

            basket.Items.Add(book);

            Assert.Equal(basket.Items.Count(), expectedNumberOfBooks);
        }
    }
}
