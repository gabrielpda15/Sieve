using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            Client.Timeout = TimeSpan.FromSeconds(15);
        }

        public async Task<bool> CheckHealth(string url, CancellationToken ct = default)
        {
            try
            {
                var response = await Client.GetAsync(url, ct);
                return response.IsSuccessStatusCode;
            }
            catch { return false; }
        }

    }
}
