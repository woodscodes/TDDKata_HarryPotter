using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public static class Discounter
    {
        private static decimal _discountApplied;

        public static decimal CalculateTotal(Basket basket)
        {
            for (int i = 0; i < basket.Items.Count() - 1; i++)
            {
                if (basket.Items[i].Isbn != basket.Items[i + 1].Isbn)
                    _discountApplied = 5m;
            }

            return basket.Total-(basket.Total*_discountApplied/100);
        }
    }
}
