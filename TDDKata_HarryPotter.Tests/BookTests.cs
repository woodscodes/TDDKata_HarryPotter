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

            Assert.Equal(book.Isbn, "0-7475-3269-9");
        }
    }
}
