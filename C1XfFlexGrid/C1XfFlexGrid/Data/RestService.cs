using C1XfFlexGrid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C1XfFlexGrid.Data
{
    public class RestService : IRestService
    {
        HttpClient client;

        public List<Customer> Items { get; private set; }

        public RestService()
        {
            client = new HttpClient();

        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            Items = new List<Customer>();

            var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Customer>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return Items;
        }

    }
}
