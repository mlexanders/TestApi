using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repositories;


namespace TestApi
{
    class Program
    {

        static async Task Main(string[] args)
        {
            // Post()
            //PostDay newDay = new PostDay();

            //PostDayRepository newDayRepository = new PostDayRepository();
            //var response = await newDayRepository.Post(newDay);
            //Console.WriteLine("POST: response = " + response.StatusCode);

            // GET()
            var daysRepo = new DayRepository();
            var days = await daysRepo.Get();
            SendDays(days);

        }

        public static void SendDays(List<Day> days)
        {
            foreach (var item in days)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Date = " + item.Date);
                Console.WriteLine("Information = " + item.Information);
                Console.WriteLine("LessonsAndTimes = " + item.LessonsAndTimes);
            }
        }
        public static void SendUsers(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Login = " + item.Login);
                Console.WriteLine("Token = " + item.Token);
                Console.WriteLine("Name = " + item.Name);
                Console.WriteLine("Role = " + item.Role);
                Console.WriteLine();
            }
        }

        public static void SendUser(User user)
        {
            Console.WriteLine("Id = " + user.Id);
            Console.WriteLine("Login = " + user.Login);
            Console.WriteLine("Name = " + user.Name);
            Console.WriteLine("Role = " + user.Role);
            Console.WriteLine();
        }
    }
}
