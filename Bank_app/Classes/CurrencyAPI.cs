using System;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bank_app.Classes
{
    class CurrencyAPI
    {       
        public decimal getCurrency (string from, string to)
        {
            RestClient client = new RestClient($"https://api.apilayer.com/currency_data/live?source={from}&currencies={to}");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "Y0bav2Rz5xOLBRYZEdyQJ2lxtXcF7Gkp");
            IRestResponse response = client.Execute(request);

            string stream = response.Content;
            stream = stream.Replace(".", ",");

            string pattern = @"(\d+,\d+)";
            var matches = Regex.Matches(stream, pattern);
            stream = "";

            foreach (var match in matches)
            {
                stream += match;
            }
            stream = stream.Replace(",", ".");
            decimal currency = Convert.ToDecimal(stream);

            return currency;
        }
    }
}
