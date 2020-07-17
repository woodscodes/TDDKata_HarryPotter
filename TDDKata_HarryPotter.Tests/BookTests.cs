using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata_HarryPotter.Core.Models;
using Xunit;
using Xunit.Sdk;

namespace TDDKata_HarryPotter.Tests
{
    public class BookTests
    {
        [Fact]
        public void ShouldCreateBook()
        {
            var book = new Book { Volume = 1, Price = 8.0m };

            Assert.IsType<Book>(book);
        }
    }
}
