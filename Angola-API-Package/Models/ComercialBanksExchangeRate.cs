using System;
using System.Collections.Generic;
using System.Text;

namespace Angola_API_Package.Models
{
    public class Buy
    {
        public string Currency { get; set; }
        public double Quotation { get; set; }
        public string Variation { get; set; }
    }

    public class Sell
    {
        public string Currency { get; set; }
        public double Quotation { get; set; }
        public string Variation { get; set; }
    }

    public class Current
    {
        public List<Buy> Buy { get; set; }
        public List<Sell> Sell { get; set; }
    }

    public class LastDay
    {
        public List<Buy> Buy { get; set; }
        public List<Sell> Sell { get; set; }
    }

    public class Variation
    {
        public List<Buy> Buy { get; set; }
        public List<Sell> Sell { get; set; }
    }

    public class Bank
    {
        public string Name { get; set; }
        public Current Current { get; set; }
        public LastDay LastDay { get; set; }
        public Variation Variation { get; set; }
    }

    public class ComercialBanksExchangeRate
    {
        public string Date { get; set; }
        public List<Bank> Banks { get; set; }
    }


}

