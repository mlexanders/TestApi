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
        private static string BaseUrl = "http://localhost:8080/api";

        //POST
        public static async Task<string> PostRequestJson(string item, string url)
        {

            string json = JsonConvert.SerializeObject(item);
            Console.WriteLine("json = " + json);
            return await PostRequestString(json, url);

        }
        public static async Task<string> PostRequestString(string item, string url)
        {
            try
            {
                var data = new StringContent(item, Encoding.UTF8, "application/json");
                var httpResponse = await client.PostAsync(BaseUrl + url, data);
                Console.WriteLine("- StatusCode" + httpResponse.StatusCode);

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
                //client.Dispose();
            }
            return null;
        }


        //GET
        public static async Task<string> GetRequest(HttpClient client, string url)
        {
            
            try
            {
                Console.WriteLine(" ты в get");

                HttpResponseMessage httpResponse = await client.GetAsync(BaseUrl + url);
                Console.WriteLine(" StatusCode= " + httpResponse.StatusCode.ToString());
                Console.WriteLine(" RequestMessage= " + httpResponse.RequestMessage.ToString());

                return await httpResponse.Content.ReadAsStringAsync();

            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message.ToString());
            }
            return null;
        }

    }
}
