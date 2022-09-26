using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyDenomination.Models
{
    
    public class AmountPriceModel
    {
        public decimal Price { get; set; }
        public int AmountPaid { get; set; }

        public decimal AmountBalance
        {
            get
            {
                return Convert.ToDecimal((AmountPaid - Price).ToString("F", CultureInfo.InvariantCulture));
            }
        }
        public List<string> BreakUpSummary { get; set; }
    }
}
