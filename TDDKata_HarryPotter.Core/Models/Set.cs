using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public class Set
    {
        private List<int> _set = new List<int>();

        public Set(int book)
        {
            _set.Add(book);
        }   

        public bool IsAcceptable(int book)
        {
            return !_set.Contains(book);
        }

        public void AddToSet(int book)
        {
            _set.Add(book);
        }

        public int Count()
        {
            return _set.Count();
        }
    }
}
