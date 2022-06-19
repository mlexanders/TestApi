using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApi.Repositories
{
    public class BaseRepository<TEntity, TKey>
    {
        public Uri Root { get; set; }
        public string Token { get; set; }
        private readonly HttpClient httpClient = new();

        public BaseRepository(string entityRoot)
        {
            Root = new Uri(AppSettings.BaseRoot + entityRoot);
            Token = AppSettings.Token;

            HttpClientHandler handler = new();
            handler.CookieContainer = new CookieContainer();
            handler.CookieContainer.Add(this.Root, new Cookie("token", Token));
            httpClient = new HttpClient(handler);
        }

        public async Task<TEntity> Get(TKey key)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync(Root + "/" + key);
            return await Deserialize<TEntity>(httpResponse);
        }
        public async Task<List<TEntity>> Get()
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync(Root + "/");
            return await Deserialize<List<TEntity>>(httpResponse);
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse)
        {
            if (httpResponse.IsSuccessStatusCode)
            {
                var jsonRequest = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonRequest);
            }
            throw new Exception("Хрень");
        }
    }
}
