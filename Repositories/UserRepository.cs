using TestApi.Models;

namespace TestApi.Repositories
{
    public class UserRepository : BaseRepository<User, int>
    {
        public UserRepository() : base(AppSettings.UsersRoot)
        {
        }
    }
}
