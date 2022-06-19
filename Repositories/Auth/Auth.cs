using System;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text;



namespace TestApi.Repositories
{
    public class Auth
    {
        private static HttpClient client = new();
        private static readonly string BaseUrl = "http://localhost:8080/api";
        private static readonly string token = "Fp9u5dsvcdM3XIm";


        public static async Task<string> PostAuthByToken()
        {

            try
            {
                var data = new StringContent(token, Encoding.UTF8);
                var httpResponse = await client.PostAsync(BaseUrl + "/auth/byToken", data);

                var result = await httpResponse.Content.ReadAsStringAsync();
                //Console.WriteLine(result);
                return result;
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message.ToString());
            }
            return null;
        }

        public static async Task GetLogApiToken()
        {

            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(BaseUrl + "/auth");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message.ToString());
            }
            finally
            {
                //client.Dispose();
            }
        }

    }
}
