using System.Net.Http;
using System.Threading.Tasks;

namespace Grocer.Common {
    public class StoreClient {
        private readonly HttpClient Client = new HttpClient();

        public async Task<TOutput> GetAsync<TOutput>(string url) {
            HttpResponseMessage response = await Client.GetAsync(url);
            return await response.Content.ReadAsAsync<TOutput>();
        }
    }
}
