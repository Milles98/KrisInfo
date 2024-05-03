using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class KrisInfoService
    {
        public static async Task GetJsonDataAll()
        {
            var days = 100;
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.krisinformation.se");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync($"/v3/news?days={days}");
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    var messages = JsonConvert.DeserializeObject<List<KrisInfoResponse>>(responseBody);
                }
                catch (JsonReaderException)
                {
                    Console.WriteLine("Prutt! Det funkade inte.");
                }
            }
        }

        public static async Task GetJsonDataOne(int id)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.krisinformation.se");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync($"/v3/news/{id}");
            if (!response.IsSuccessStatusCode)
            {

            }

            else if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    var message = JsonConvert.DeserializeObject<KrisInfoResponse>(responseBody);
                }
                catch (JsonReaderException)
                {
                    Console.WriteLine("Prutt! Det funkade inte.");
                }
            }
        }
    }
}
