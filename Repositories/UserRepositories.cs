using System;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;



namespace TestApi.Repositories
{
    class UserRepositories
    {
        private static HttpClient client = new();
        private static string ServerRoot = "http://localhost:8080/api/";

        //POST
        public static async Task<string> PostRequestJson(string item, string url)
        {
           
            string json = JsonConvert.SerializeObject(item);
            Console.WriteLine("json = " + json);
            return await PostRequestString(json, ServerRoot);


        }
        public static async Task<string> PostRequestString(string item, string url)
        {
            try
            {
                var data = new StringContent(item, Encoding.UTF8, "application/json");
                var httpResponse = await client.PostAsync(url, data);

                var result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                return result;
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message.ToString());
            }
            finally
            {
                client.Dispose();
            }
            return null;
        }


        // GET
    //    static async Task<string> Get(string url)
    //    {
    //        HttpResponseMessage httpResponse = await client.GetAsync(url);
    //        var jsonRequest = await httpResponse.Content.ReadAsStringAsync();
    //        //return JsonConvert.DeserializeObject<Rootobject>(jsonRequest);
    //    }

    }
}
