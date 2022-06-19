using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repositories;



namespace TestApi
{
    class Program
    {

        static async Task Main(string[] args)
        {
            var dayRepository = new DayRepository();
            var days = await dayRepository.Get();

            days.ForEach(d => Console.WriteLine(d.Date));
        }
    }
}
