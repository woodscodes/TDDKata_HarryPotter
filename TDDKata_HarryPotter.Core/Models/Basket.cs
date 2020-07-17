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
            var uniques = new HashSet<int>(books);
            if (uniques.Count() == 1)
                uniques.Clear();

            var discount = 0m;

            if (uniques.Count() == 2)
            {
                discount = 0.95m;
                Total += (8 * uniques.Count()) * discount;
            }

            if(uniques.Count() == 3)
            {
                discount = 0.9m;
                Total += (8 * uniques.Count()) *discount;
            }

            if(uniques.Count() == 4)
            {
                discount = 0.8m;
                Total += (8 * uniques.Count()) * discount;
            }
            
            if(uniques.Count() == 5)
            {
                discount = 0.8m;
                Total += (8 * uniques.Count()) * discount;
            }    
            
            var numberOfBooks = books.Length - uniques.Count();
            Total += (numberOfBooks * 8);
        }        
    }
}
