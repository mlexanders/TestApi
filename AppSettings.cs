using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    public static class AppSettings
    {
        public static string Token { get; } = "Fp9u5dsvcdM3XIm";
        public static string BaseRoot { get; } = "http://localhost:8080/api/";
        public static string UsersRoot { get; } = "users";
        public static string DaysRoot { get; } = "days";
    }
}
