using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public class Basket
    {
        public decimal Total { get; set; }

        public Basket(List<int> books)
        {
            var sortedListOfBooks = books.OrderByDescending(b => b);

            Total = Set.Add(sortedListOfBooks);            
        }
    }
}

