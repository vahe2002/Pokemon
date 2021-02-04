using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApi.Models.Dto;

namespace TodoApi.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        public async Task<PokemonDto> GetPokemon()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage
                {RequestUri = new Uri("https://pokeapi.co/api/v2/pokemon/ditto"), Method = HttpMethod.Get};
            request.Headers.Add("X-Api-Key", "9da01f86-04f6-4d87-b5f6-e8c53f7bc300");
            var response = await httpClient.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<PokemonDto>(json);
            return data;
        }
        
    }
}