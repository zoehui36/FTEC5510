using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UI.CommonData;


namespace UI
{
    public static class ClientHelper
    {
        public static HttpClient client = new HttpClient();
        public static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static async Task<HttpStatusCode> GetExchagneRate(string id)
        {
            HttpResponseMessage response = await client.GetAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }
        public static async Task<HttpStatusCode> GenerateECNY()
        {
            HttpResponseMessage response = await client.PostAsync(
                $"PBOC/GernerateECNY", null);
            return response.StatusCode;
        }

        public static async Task<AccountInfo> GetAccountInfo(string bankName, string accountNumber)
        {

            AccountInfo account = null;
            HttpResponseMessage response = await client.GetAsync($"{bankName}/{accountNumber}");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                account = JsonConvert.DeserializeObject<AccountInfo>(jsonString);
            }
            return account;
        }

        public static async Task<int> GetENCYamount(string accountNumber)
        {
            int amount = 0;
            try
            {

                HttpResponseMessage response = await client.GetAsync($"PBOC/queryAccountECNYBalance/{accountNumber}");
                if (response.IsSuccessStatusCode)
                {
                    string temp = await response.Content.ReadAsStringAsync();
                    amount = Convert.ToInt32(temp) * 100;
                }
                return amount;
            }
            catch
            {
                return amount;
            }
        }

        public static async Task<HttpStatusCode> BuyInECNY(string bankName, string accountNumber, string ECNYAmount, string currentType)
        {
            HttpResponseMessage response = await client.PostAsync(
                $"{bankName}/BuyInECNY/{accountNumber}/{ECNYAmount}/{currentType}", null);
            return response.StatusCode;

        }

        public static async Task<HttpStatusCode> WithdrawCNY(string bankName, string accountNumber, string ECNYAmount)
        {
            HttpResponseMessage response = await client.PostAsync(
                $"{bankName}/WithdrawCNY/{accountNumber}/{ECNYAmount}/", null);
            return response.StatusCode;

        }

        public static async Task<HttpStatusCode> WithdrawTHB(string bankName, string accountNumber, string ECNYAmount)
        {
            HttpResponseMessage response = await client.PostAsync(
                $"{bankName}/WithdrawTHAI/{accountNumber}/{ECNYAmount}/", null);
            return response.StatusCode;

        }

        public static async Task<HttpStatusCode> Payment(string bankName, string accountNumber, string ECNYAmount, string receiveBank, string receiveAccount)
        {
            HttpResponseMessage response = await client.PostAsync(
              $"{bankName}/payment/{accountNumber}/{ECNYAmount}/{receiveBank}/{receiveAccount}", null);
            return response.StatusCode;

        }

        public static async Task<decimal> GetExchangeRate()
        {
            decimal rate = 0;
            //return (decimal)5.249;
            HttpResponseMessage response = await client.GetAsync($"GetTHBRateOnly/");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                rate = Convert.ToDecimal(jsonString);
                // account = JsonConvert.DeserializeObject<AccountInfo>(jsonString);
            }
            return rate;



        }
    }
}
