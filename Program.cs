using System;
using System.Threading.Tasks;
using TestApi.Repositories.Auth;
using TestApi.Repositories;




namespace TestApi
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var a = await PostAuthByToken();   
            Console.ReadLine();
        }
    }
}
