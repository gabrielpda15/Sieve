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

        private string APIEndpoint { get; }

        public ApiManager(string baseUrl, string apiUrl)
        {
            APIEndpoint = apiUrl;
            Client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)/*,
                Timeout = TimeSpan.FromSeconds(30)*/
            };
        }

        public async Task<bool> CheckHealth(string url)
        {
            try
            {
                var response = await Client.GetAsync(this.APIEndpoint + url).ConfigureAwait(false);
                return response.IsSuccessStatusCode && (await response.Content.ReadAsStringAsync().ConfigureAwait(false)) == "healthy";
            }
            catch { return false; }
        }

        public async Task<T> GetAsync<T>(string url, string token = null, bool expectSuccess = true) 
            where T : class
        {
            try
            {
                if (token != null)
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var response = await Client.GetAsync(this.APIEndpoint + url).ConfigureAwait(false);

                if (expectSuccess)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    }
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }
                
            } catch { }

            return null;
        }

        public async Task<T> PostAsync<T, TBody>(string url, TBody body, string token = null, bool expectSuccess = true)
            where T : class where TBody : class
        {
            try
            {
                if (token != null)
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await Client.PostAsync(this.APIEndpoint + url, content).ConfigureAwait(false);

                if (expectSuccess)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    }
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }

                
            }
            catch { }

            return null;
        }

        public async Task<T> PutAsync<T, TBody>(string url, TBody body, string token = null, bool expectSuccess = true)
            where T : class where TBody : class
        {
            try
            {
                if (token != null)
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await Client.PutAsync(this.APIEndpoint + url, content).ConfigureAwait(false);

                if (expectSuccess)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    }
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }
            }
            catch { }

            return null;
        }

        public async Task<T> DeleteAsync<T>(string url, string token = null, bool expectSuccess = true)
            where T : class
        {
            try
            {
                if (token != null)
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SieveAuth", token);

                var response = await Client.DeleteAsync(this.APIEndpoint + url).ConfigureAwait(false);

                if (expectSuccess)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    }
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                }
                
            }
            catch { }

            return null;
        }
    }
}
