using System;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using TestApi.Models;

namespace TestApi.Repositories
{
    class UserRepositories : BaseRepository<User, int>
    {
        public UserRepositories() : base(AppSettings.UsersRoot)
        {
        }
    }
}
