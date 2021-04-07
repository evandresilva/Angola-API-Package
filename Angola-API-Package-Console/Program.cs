using Angola_API_Package;
using System;

namespace Angola_API_Package_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var counties = AngolaAPIService.GetCountiesAssync("Luanda");
            foreach (var county in counties.Result)
            {
                Console.WriteLine(county.Nome);
            }
            Console.WriteLine();

            var provinces = AngolaAPIService.GetProvincesAssync();
            foreach (var province in provinces.Result)
            {
                Console.WriteLine(province.Nome);
            }
            var comercialExchanges = AngolaAPIService.GetComercialBanksExchangeRateAssync();
            foreach (var comercialExchange in comercialExchanges.Result.Banks)
            {
                Console.WriteLine(comercialExchange.Name);
            }
            var interestRateBNA = AngolaAPIService.GetBNAInterestRate();
            Console.WriteLine($"Taxa de cambio do BNA : { interestRateBNA.Rate }");
        }
    }
}
