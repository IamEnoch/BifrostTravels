using BifrostTravels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Helpers
{
    public class HttpDataHelper
    {
        public HttpClient client { get; set; }

        public HttpDataHelper(string baseadress, string accessToken, List<(string name, string value)> headers)
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(baseadress);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            foreach(var(name, value) in headers)
            {
                client.DefaultRequestHeaders.Add(name, value);
            }
        }

        /// <summary>
        /// Get request
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<ResponseMessage> GetItemAsync(string endpoint)
        {
            var response = await client.GetAsync(endpoint);
            var responseString = await response.Content.ReadAsStringAsync();
            var returnObject = JsonConvert.DeserializeObject(responseString);

            return new ResponseMessage(response.IsSuccessStatusCode, response.StatusCode, returnObject);
        }

        /// <summary>
        /// Post request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<ResponseMessage> PostItemAsync<T>(string endpoint, T item)
        {
            var requestString = JsonConvert.SerializeObject(item);
            var content = new StringContent(requestString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(endpoint, content);

            var responseString = await response.Content.ReadAsStringAsync();
            var returnObject = JsonConvert.DeserializeObject(responseString);

            return new ResponseMessage(response.IsSuccessStatusCode, response.StatusCode, returnObject);
        }
    }
}
