using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public static class Set
    {
        private static List<HashSet<int>> _sets = new List<HashSet<int>>();

        internal static decimal Add(IOrderedEnumerable<int> sortedListOfBooks)
        {            
            var mainSet = new HashSet<int>();
            var otherSet = new HashSet<int>();
            var setThree = new HashSet<int>();

            _sets.Add(mainSet);
            _sets.Add(otherSet);
            _sets.Add(setThree);

            foreach (var book in sortedListOfBooks)
            {
                if (!mainSet.Contains(book))
                    mainSet.Add(book);
                else if (!otherSet.Contains(book))
                    otherSet.Add(book);
                else
                    setThree.Add(book);
            }

            if (otherSet.Count() == 0)
                _sets.Remove(otherSet);

            var total = 0m;
            foreach (var set in _sets)
            {
                total += calculateSetCost(set);
            }
            return total;
        }

        private static decimal calculateSetCost(HashSet<int> set)
        {
            switch (set.Count())
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
