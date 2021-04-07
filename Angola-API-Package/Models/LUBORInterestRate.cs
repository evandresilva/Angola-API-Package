using System;
using System.Collections.Generic;
using System.Text;

namespace Angola_API_Package.Models
{

    public class MaturityRate
    {
        public string Maturity { get; set; }
        public string Rate { get; set; }
    }

    public class LUIBORInterestRate
    {
        public string Date { get; set; }
        public List<MaturityRate> MaturitiesRates { get; set; }
    }

}
