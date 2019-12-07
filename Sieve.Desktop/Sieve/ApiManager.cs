using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve
{
    public class ApiManager
    {
        private HttpClient Client { get; }

        public ApiManager(string baseUrl)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(baseUrl);
            Client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<bool> CheckHealth(string url)
        {
            try
            {
                var response = await Client.GetAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch { return false; }
        }

        public async Task<T> GetAsync<T>(string url, string token) 
            where T : class
        {
            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);
                var response = await Client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());                    
                }
            } catch { }

            return null;
        }

        public async Task<T> PostAsync<T, TBody>(string url, TBody body, string token, CancellationToken ct = default)
            where T : class where TBody : class
        {
            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await Client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
            }
            catch { }

            return null;
        }

        public async Task<T> PutAsync<T, TBody>(string url, TBody body, string token, CancellationToken ct = default)
            where T : class where TBody : class
        {
            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await Client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
            }
            catch { }

            return null;
        }

        public async Task<T> DeleteAsync<T>(string url, string token, CancellationToken ct = default)
            where T : class
        {
            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);
                var response = await Client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
            }
            catch { }

            return null;
        }
    }
}
