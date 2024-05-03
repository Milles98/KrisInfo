using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class KrisInfoService : IKrisInfoService
    {
        private readonly HttpClient _client;
        public KrisInfoService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<KrisInfoResponse>> GetJsonDataAll()
        {
            var days = 300;

            HttpResponseMessage response = await _client.GetAsync($"/v3/news?days={days}");
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    var messages = JsonConvert.DeserializeObject<List<KrisInfoResponse>>(responseBody);
                    return messages;
                }
                catch (JsonReaderException)
                {
                    throw new Exception("Error");
                }
            }
            return null;
        }

        public async Task<KrisInfoResponse> GetJsonDataOne(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"/v3/news/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }

            else if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    var message = JsonConvert.DeserializeObject<KrisInfoResponse>(responseBody);
                    return message;
                }
                catch (JsonReaderException)
                {
                    throw new Exception("Error");
                }
            }
            return null;
        }
    }
}
