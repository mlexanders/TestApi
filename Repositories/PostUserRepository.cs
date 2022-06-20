using TestApi.Models;

namespace TestApi.Repositories
{
    public class PostUserRepository : BaseRepository<PostUser, int>
    {
        public PostUserRepository() : base(AppSettings.UsersRoot)
        {
        }
    }
}
