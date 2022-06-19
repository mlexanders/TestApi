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
            //var dayRepository = new DayRepository();
            //var days = await dayRepository.Get();
           

            //var startRep = new StartModelsRepository();
            //var start = await startRep.Get();

            // Get
            var userRep = new UserRepository();
            var user = await userRep.Get();








            //Console.WriteLine(user.Id);
            //Console.WriteLine(user.Login);
            //Console.WriteLine(user.Name);
            //Console.WriteLine(user.Role);
            //Console.WriteLine("");

            for (int i = 0; i < user.Count; i++)
            {
                Console.WriteLine(user[i].Id);
                Console.WriteLine(user[i].Login);
                Console.WriteLine(user[i].Name);
                Console.WriteLine(user[i].Role);
                Console.WriteLine(user[i].Password);
            }


            //POST

            //var newUser = new PostUser();
            //var pass = new Password();


            //Console.WriteLine("");

            //Console.WriteLine("login = " + newUser.login);
            //Console.WriteLine("name = " + newUser.name);
            //Console.WriteLine("role = " + newUser.role);
            //Console.WriteLine("password.Id = " + newUser.password.Id);
            //Console.WriteLine("password.Value = " + newUser.password.Value);
            //Console.WriteLine("");

            //var newUserREp = new PostUserRepository();
            //var res = await newUserREp.Post(newUser);

            //Console.WriteLine("resp = " + res.StatusCode);





            // user = await userRep.Get();


            //for (int i = 0; i < user.Count; i++)
            //{
            //    Console.WriteLine(user[i].Id);
            //    Console.WriteLine(user[i].Login);
            //    Console.WriteLine(user[i].Name);
            //    Console.WriteLine(user[i].Role);
            //    Console.WriteLine(user[i].Password);
            //}




            //Console.WriteLine(user[0].Id);
            //Console.WriteLine(user[0].Login);
            //Console.WriteLine(user[0].Name);
            //Console.WriteLine(user[0].Role);
            //Console.WriteLine("");



            //UPDATE

            //var newUser = user[0];
            //newUser.Name = "Evkakiy123";
            //newUser.Login = "Rashod123";

            //var resp = await userRep.Update(user[0].Id, newUser);
            //Console.WriteLine("StatusCode(update) = " + resp.StatusCode);


            //Console.WriteLine(user[0].Id);
            //Console.WriteLine(user[0].Login);
            //Console.WriteLine(user[0].Name);
            //Console.WriteLine(user[0].Role);
            //Console.WriteLine("");


            //DELETE

            //var msg = await userRep.Delete(5);
            //   Console.WriteLine(msg.StatusCode);
            //   Console.WriteLine(await msg.Content.ReadAsStringAsync());


            ////////
            //user.Name = "QWERTYlang";
            //var af = await userRep.Post(user);
            //Console.WriteLine("StatusCode( Post(user) ) = " + af.StatusCode);

            //user = await userRep.Get(106);


            //Console.WriteLine(user.Id);
            //Console.WriteLine(user.Login);
            //Console.WriteLine(user.Name);
            //Console.WriteLine(user.Role);



            //user.ForEach(d => Console.WriteLine(d.Id));
            //user[106].Name = "WANNNAA";
            //var res = await userRep.Update(237, user[106]);
            //Console.WriteLine(res.StatusCode);
            //for (int i = 0; i < user.Count; i++)
            //{
            //    Console.WriteLine(user[i].Id);
            //    Console.WriteLine(user[i].Login);
            //    Console.WriteLine(user[i].Name);
            //    Console.WriteLine(user[i].Role);
            //    Console.WriteLine(user[i].Password);
            //}
            //int a = Console.Read();
            //User userID = user[];

        }
    }
}
