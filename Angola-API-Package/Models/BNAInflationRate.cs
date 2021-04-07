using System;
using System.Collections.Generic;
using System.Text;

namespace Angola_API_Package.Models
{
    public class TypeRate
    {
        public string Type { get; set; }
        public string Rate { get; set; }
    }

    public class BNAInflationRate
    {
        public string Date { get; set; }
        public string Status { get; set; }
        public List<TypeRate> TypesRates { get; set; }
    }
}
