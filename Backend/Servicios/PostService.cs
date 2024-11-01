using Backend.DTO;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Backend.Servicios
{
    public class PostService : IPostService
    {
        private HttpClient _httpClient;

        public PostService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<PostDTO>> get()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var resul=await _httpClient.GetAsync(url);

            var body=await resul.Content.ReadAsStringAsync();
            var opciones= new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var post=JsonSerializer.Deserialize<IEnumerable<PostDTO>>(body);
            return post;
        }

    }
}
