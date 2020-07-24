using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata_HarryPotter.Core.Models;
using Xunit;

namespace TDDKata_HarryPotter.Tests
{
    public class SetTests
    {
        [Fact]
        public void ShouldCreate2SetsOf1()
        {
            var books = new List<int> { 1, 1 };
            var sets = new SetManager(books);
           
            Assert.Equal(2, sets.Count());
        }
        
        [Fact]
        public void ShouldCreate1SetOf2()
        {
            var books = new List<int> { 1, 2 };
            var sets = new SetManager(books);

            Assert.Equal(1, sets.Count());
        }
    }
}
