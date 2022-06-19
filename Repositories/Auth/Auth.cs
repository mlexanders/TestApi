using System;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text;


namespace TestApi.Repositories.Auth
{
    public class Auth
    {
        private static HttpClient client = new();
        private static string ServerRoot = "http://localhost:8080/api/byToken";
        private static string token = "Fp9u5dsvcdM3XIm";


        public static async Task<string> PostAuthByToken()
        {

            try
            {
                var data = new StringContent(token, Encoding.UTF8);
                var httpResponse = await client.PostAsync(ServerRoot, data);

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


    }
}
