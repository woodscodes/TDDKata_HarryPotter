using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public class Basket
    {
        public List<Book> Items { get; set; }
        public decimal Total { get; set; }

        public Basket()
        {
            Items = new List<Book>();
        }
    }
}
