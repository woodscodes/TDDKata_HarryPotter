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
        public void ShouldAddABook()
        {
            var basket = new Basket();
            var book = new Book();
            var expectedNumberOfBooks = 1;

            basket.Items.Add(book);

            Assert.Equal(basket.Items.Count(), expectedNumberOfBooks);
        }

        [Fact]
        public void ShouldProvideATotal()
        {
            var basket = new Basket();

            basket.Items.Add(new Book { Isbn = "0-7475-3269-9", Price = 8.0m, Title = "Philosopher's Stone" });
            basket.Items.Add(new Book { Isbn = "0-7475-3849-2", Price = 8.0m, Title = "Chamber of Secrets" });
            basket.Items.Add(new Book { Isbn = "0-7475-4215-5", Price = 8.0m, Title = "Prisoner of Azkaban" });

            var expectedTotal = 24.0m;

            Assert.Equal(basket.Total, expectedTotal);
        }
    }
}
