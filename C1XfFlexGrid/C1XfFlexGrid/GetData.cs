using C1XfFlexGrid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace C1XfFlexGrid
{
    class GetData
    {
        public List<Customer> Customers { get; private set; }

        public static string WebApiUrl = "https://webapiapp20190305040804.azurewebsites.net/api/";

        public async Task<List<Customer>> AsyncGetCustomers()
        {
            Customers = new List<Customer>();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(WebApiUrl);
            
            try
            {
                var response = await httpClient.GetAsync("customers");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Customers = JsonConvert.DeserializeObject<List<Customer>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return Customers;
        }

    }
}
