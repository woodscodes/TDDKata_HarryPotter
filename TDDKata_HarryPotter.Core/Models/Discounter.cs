using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata_HarryPotter.Core.Models
{
    public static class Discounter
    {
        public static decimal Price(params int[] books)
        {
            var basket = new Basket(books);

            return basket.Total;
        }
    }
}
