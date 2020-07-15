using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata_HarryPotter.Core.Models;
using Xunit;

namespace TDDKata_HarryPotter.Tests
{
    public class BookTests
    {
        [Fact]
        public void ShouldInstantiateABook()
        {
            var book = new Book();

            Assert.IsType<Book>(book);
        }
                
        [Fact]
        public void ShouldHaveISBN()
        {
            var book = new Book();

            book.Isbn = "0-7475-3269-9";

            Assert.Equal("0-7475-3269-9", book.Isbn);
        }

        [Fact]
        public void ShouldHaveTitle()
        {
            var book = new Book
            {
                Title = "Harry Potter and the Philosopher's Stone"
            };

            Assert.Equal("Harry Potter and the Philosopher's Stone", book.Title);
        }

        [Fact]
        public void ShouldHavePrice()
        {
            var book = new Book
            {
                Price = 8.0m
            };

            Assert.Equal(8.0m, book.Price);
        }
    }
}
