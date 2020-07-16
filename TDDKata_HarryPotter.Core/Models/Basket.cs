using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public class Basket
    {
        public List<Book> Items { get; set; }
        public decimal Total => getTotal();

        public Basket()
        {
            Items = new List<Book>();
        }

        private decimal getTotal()
        {
            var total = 0m;
            foreach (var book in Items)
                total += book.Price;

            return total;
        }
    }
}
