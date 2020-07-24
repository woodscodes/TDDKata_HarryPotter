using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public class SetManager
    {
        private List<HashSet<int>> _discountCombinations = new List<HashSet<int>>();

        public SetManager(List<int> books)
        {
            BuildSets(books);
        }

        public void BuildSets(List<int> books)
        {
            foreach (var book in books)
            {
                if (!_discountCombinations.Any(d => d.Add(book)))
                    _discountCombinations.Add(new HashSet<int> { book });
            }
        }

        public int Count()
        {
            return _discountCombinations.Count();
        }
    }
}
