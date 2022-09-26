using CurrencyDenomination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyDenomination.Services
{
    public interface IGBPBreakupService
    {
        public GBPCurrencyModel GetBrakeupDenomination(GBPCurrencyModel model);
    }
}
