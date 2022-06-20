using TestApi.Models;

namespace TestApi.Repositories
{
    public class CurrentUserRepository : BaseRepository<User, int>
    {
        public CurrentUserRepository() : base(AppSettings.CurrentUsers)
        {
        }
    }
}
