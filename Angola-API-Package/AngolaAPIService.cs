using Angola_API_Package.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Angola_API_Package
{
    public static class AngolaAPIService
    {
        static readonly HttpClient client = new HttpClient();
        private static async Task<T> GetDataFromAngolaAPIAsync<T>(string endPoint)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Erro ao carregar dados do Angola API",e);
            }
        }

        #region Geography
        /// <summary>
        /// Consultar lista de municípios de forma assíncrona
        /// </summary>
        public static async Task<ICollection<CountyModel>> GetCountiesAssync(string province)
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<ICollection<CountyModel>>
                    ($"https://angolaapi.herokuapp.com/api/v1/geography/county?provincia={province}");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar municipios da provincia {province} apartir do Angola API");
            }
        }
        /// <summary>
        /// Consultar lista de municipios de Angola
        /// </summary>
        public static ICollection<CountyModel> GetCounties(string province)
        {
            try
            {
                var data =  GetDataFromAngolaAPIAsync<ICollection<CountyModel>>
                    ($"https://angolaapi.herokuapp.com/api/v1/geography/county?provincia={province}");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar municipios da provincia {province} apartir do Angola API");
            }
        }
        /// <summary>
        /// Consultar lista de provincias de Angola de forma assíncrona
        /// </summary>
        public static async Task<ICollection<ProvinceModel>> GetProvincesAssync()
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<ICollection<ProvinceModel>>
                    ($"https://angolaapi.herokuapp.com/api/v1/geography/provinces");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
         } 
        /// <summary>
        /// Consultar lista de provincias de Angola
        /// </summary>
        public static ICollection<ProvinceModel>GetProvinces()
        {
            try
            {
                var data =  GetDataFromAngolaAPIAsync<ICollection<ProvinceModel>>
                    ($"https://angolaapi.herokuapp.com/api/v1/geography/provinces");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
         }
        #endregion

        #region Finance

        /// <summary>
        ///  Consultar taxa de juros do bna forma assíncrona
        /// </summary>
        public static async Task<BNAInterestRate> GetBNAInterestRateAsync()
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<BNAInterestRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/interest/bna");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }

        /// <summary>
        /// Consultar taxa de juros do bna
        /// </summary>
        public static BNAInterestRate GetBNAInterestRate()
        {
            try
            {
                var data = GetDataFromAngolaAPIAsync<BNAInterestRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/interest/bna");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }

        /// <summary>
        /// Consultar taxa de juros do bna de forma assincrona
        /// </summary>
        public static async Task<LUIBORInterestRate> GetLUIBORInterestRateAsync()
        {
            try
            {
                var data =  await GetDataFromAngolaAPIAsync<LUIBORInterestRate>
                ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/interest/luibor");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }

        /// <summary>
        /// Consultar taxa de juros do bna
        /// </summary>
        public static LUIBORInterestRate GetLUIBORInterestRate()
        {
            try
            {
                var data = GetDataFromAngolaAPIAsync<LUIBORInterestRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/interest/bna");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }

        /// <summary>
        /// Consultar taxa de inflação do bna de forma assincrona
        /// </summary>
        public static async Task<BNAInflationRate> GetBNAInflationRateAsync()
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<BNAInflationRate>
                ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/inflation");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }

        /// <summary>
        /// Consultar taxa de inflação do bna
        /// </summary>
        public static BNAInflationRate GetBNAInflationRate()
        {
            try
            {
                var data = GetDataFromAngolaAPIAsync<BNAInflationRate>
               ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/inflation");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }
        /// <summary>
        /// Consultar lista de taxas de câmbio dos bancos de Angola de forma assíncrona
        /// </summary>
        public static async Task<ComercialBanksExchangeRate>GetComercialBanksExchangeRateAssync()
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<ComercialBanksExchangeRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/comercial-exchange");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        } 
        /// <summary>
        /// Consultar lista de taxas de câmbio dos bancos de Angola
        /// </summary>
        public static BNAMainExchangeRate GetComercialBanksExchangeRate()
        {
            try
            {
                var data =  GetDataFromAngolaAPIAsync<BNAMainExchangeRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/comercial-exchange");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }
        public static async Task<BNAMainExchangeRate>GetBNAMainExchangeRateAssync()
        {
            try
            {
                var data = await GetDataFromAngolaAPIAsync<BNAMainExchangeRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/exchange");
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        } 
        /// <summary>
        /// Consultar lista de taxas de câmbio dos bancos de Angola
        /// </summary>
        public static BNAMainExchangeRate GetBNAMainExchangeRate()
        {
            try
            {
                var data =  GetDataFromAngolaAPIAsync<BNAMainExchangeRate>
                    ($"https://angolaapi.herokuapp.com/api/v1/banks/rates/exchange");
                return data.Result;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao listar provincias apartir do Angola API");
            }
        }
        #endregion

    }

}
