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
        private ICollection<Set> _sets;

        public decimal Total { get; set; }
        
        public Basket(int[] books)
        {
            var uniques = books.Distinct();
            var discount = 0m;

            if (uniques.Count() == 2)
                discount = 0.95m;    
            

            var numberOfBooks = books.Length;
            Total = (numberOfBooks * 8) * discount;
        }        
    }
}
