using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace MvApp.ApiLivros
{
    public static class Api
    {
        public static async Task<List<Model.Livro>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://mvalivros.azurewebsites.net/api/livros");
                
                var Livros = JsonConvert.DeserializeObject<List<Model.Livro>>(json);
                return Livros;
            }
        }
    }
}
