using System;
using System.Collections.Generic;
using System.Text;

namespace Angola_API_Package.Models
{
    public class CurrencyRate
    {
        public string Currency { get; set; }
        public double Rate { get; set; }
    }

    public class BNAMainExchangeRate
    {
        public List<CurrencyRate> CurrenciesRates { get; set; }
    }
}
