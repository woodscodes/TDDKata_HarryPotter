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
            var uniqueIsbnCounter = 0;

            for (int i = 0; i < basket.Items.Count() - 1; i++)
            {
                if (basket.Items[i].Isbn != basket.Items[i + 1].Isbn)
                {
                    uniqueIsbnCounter++;
                }
            }

            return basket.Total-(basket.Total*getDiscount(uniqueIsbnCounter)/100);
        }

        private static decimal getDiscount(int uniqueIsbnCounter)
        {
            switch (uniqueIsbnCounter)
            {
                case 1:
                    _discountApplied = 5m;
                    break;
                case 2:
                    _discountApplied = 10m;
                    break;
                case 3:
                    _discountApplied = 20m;
                    break;
                case 4:
                    _discountApplied = 25m;
                    break;
                default:
                    _discountApplied = 0m;
                    break;
            }

            return _discountApplied;
        }
    }
}
