using System.Net.Http;
using System.Threading.Tasks;

namespace practical8.Services
{
    public class WebDownloadService
    {
        private readonly HttpClient _httpClient;

        public WebDownloadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> DownloadStringAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
