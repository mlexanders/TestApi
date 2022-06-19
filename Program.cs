using System;
using System.Threading.Tasks;
using TestApi.Repositories;
using System.Net.Http;
using TestApi.Models;
using Newtonsoft.Json;



namespace TestApi
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            HttpClient token = new();
            var a = await Auth.PostAuthByToken(token);
           // Console.WriteLine(a);

            await Auth.GetLogApiToken(token);


            User us = new User();
            Console.WriteLine(await UserRepositories.PostRequestJson(JsonConvert.SerializeObject(us) ,"/users/createAll"));
           
    



           Console.WriteLine("END");
            //Console.ReadLine();

        }
    }
}
