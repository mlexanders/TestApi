using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            //var startRep = new StartModelsRepository();
            //var start = await startRep.Get();

            // Get() all
            var usersRep = new UserRepository();
            var users = await usersRep.Get();
            SendUsers(users);


            // Get(id) 
            var userRep = new UserRepository();
            var user = await usersRep.Get(users[users.Count-1].Id);
            SendUser(user);


            //POST
            var newUser = new PostUser();
            var pass = new Password();
            newUser.password = pass;

            var newUserRepository = new PostUserRepository();
            var response = await newUserRepository.Post(newUser);
            Console.WriteLine("POST: response = " + response.StatusCode);


            // Get() all
            users = await usersRep.Get();
            SendUsers(users);

            //UPDATE
            newUser.name = "boulevard";
            newUser.login = "Asd@mail.ru";
            response = await newUserRepository.Update(users[users.Count-1].Id, newUser);

            Console.WriteLine("UPDATE: StatusCode(update) = " + response.StatusCode);

            // Get() all
            users = await usersRep.Get();
            SendUsers(users);


            ////DELETE
            //var msg = await userRep.Delete(users[users.Count - 1].Id);
            //Console.WriteLine("DELETE: StatusCode" + msg.StatusCode);
            //Console.WriteLine(await msg.Content.ReadAsStringAsync());


            // Get() all
            users = await usersRep.Get();
            SendUsers(users);

            ////DELETE all
            //List<int> list = new();
            //foreach (var item in users)
            //{
            //    list.Add(item.Id);
            //    Console.WriteLine("id is - " + item.Id.ToString());
            //}
            //var msg = await userRep.Delete(list);
            //Console.WriteLine("DELETE: StatusCode" + msg.StatusCode);
            //Console.WriteLine(await msg.Content.ReadAsStringAsync());
        }


        public static void SendUsers(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine("Id = " + item.Id);
                Console.WriteLine("Login = " + item.Login);
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
