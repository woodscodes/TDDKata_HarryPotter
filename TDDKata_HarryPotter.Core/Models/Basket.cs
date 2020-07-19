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
        private List<Set> _sets = new List<Set>();

        public decimal Total => getTotal();

        public Basket(List<int> books)
        {
            var sortedListOfBooks = books.OrderByDescending(b => b);

            foreach (var book in sortedListOfBooks)
            {
                AddToBasket(book);
            }        
        }

        private void AddToBasket(int book)
        {
            if (_sets.Any(s => s.IsAcceptable(book)))
                _sets.Where(s => s.IsAcceptable(book)).FirstOrDefault().AddToSet(book);
            else
                _sets.Add(new Set(book));
        }

        private decimal getTotal()
        {
            var total = 0m;
            foreach (var set in _sets)
            {
                total += calculateSetDiscount(set.Count());
            }
            return total;
        }

        private decimal calculateSetDiscount(int setCount)
        {
            switch (setCount)
            {
                case 0:
                    return 0m;
                case 1:
                    return 8m;
                case 2:
                    return (8 * 2) * 0.95m;
                case 3:
                    return (8 * 3) * 0.9m;
                case 4:
                    return (8 * 4) * 0.8m;
                case 5:
                    return (8 * 5) * 0.75m;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}

