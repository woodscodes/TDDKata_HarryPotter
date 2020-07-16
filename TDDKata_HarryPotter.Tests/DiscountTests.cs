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

        [Fact]
        public void ShouldCalculateDiscountForThreeUniqueBook()
        {
            var basket = new Basket();
            basket.Items.Add(new Book { Isbn = "0-7475-3269-9", Price = 8.0m, Title = "Philosopher's Stone" });
            basket.Items.Add(new Book { Isbn = "0-7475-3849-2", Price = 8.0m, Title = "Chamber of Secrets" });
            basket.Items.Add(new Book { Isbn = "0-7475-4215-5", Price = 8.0m, Title = "Prisoner of Azkaban" });
            var expectedTotal = 21.6m;

            var total = Discounter.CalculateTotal(basket);

            Assert.Equal(total, expectedTotal);
        }

        [Fact]
        public void ShouldCalculateDiscountForFourUniqueBooks()
        {
            var basket = new Basket();
            basket.Items.Add(new Book { Isbn = "0-7475-3269-9", Price = 8.0m, Title = "Philosopher's Stone" });
            basket.Items.Add(new Book { Isbn = "0-7475-3849-2", Price = 8.0m, Title = "Chamber of Secrets" });
            basket.Items.Add(new Book { Isbn = "0-7475-4215-5", Price = 8.0m, Title = "Prisoner of Azkaban" });
            basket.Items.Add(new Book { Isbn = "0-7475-4624-X", Price = 8.0m, Title = "Goblet of Fire" });
            var expectedTotal = 25.6m;

            var total = Discounter.CalculateTotal(basket);

            Assert.Equal(total, expectedTotal);
        }

        [Fact]
        public void ShouldCalculateDiscountForFiveUniqueBooks()
        {
            var basket = new Basket();
            basket.Items.Add(new Book { Isbn = "0-7475-3269-9", Price = 8.0m, Title = "Philosopher's Stone" });
            basket.Items.Add(new Book { Isbn = "0-7475-3849-2", Price = 8.0m, Title = "Chamber of Secrets" });
            basket.Items.Add(new Book { Isbn = "0-7475-4215-5", Price = 8.0m, Title = "Prisoner of Azkaban" });
            basket.Items.Add(new Book { Isbn = "0-7475-4624-X", Price = 8.0m, Title = "Goblet of Fire" });
            basket.Items.Add(new Book { Isbn = "0-7475-5100-6", Price = 8.0m, Title = "Order of the Pheonix" });
            var expectedTotal = 30m;

            var total = Discounter.CalculateTotal(basket);

            Assert.Equal(total, expectedTotal);
        }
        
        [Fact]
        public void ShouldCalculateDiscountForTwoSetsOfUniqueBooks()
        {

        }
    }
}
