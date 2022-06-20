using TestApi.Models;

namespace TestApi.Repositories
{
    public class PostDayRepository : BaseRepository<PostDay, int>
    {
        public PostDayRepository() : base(AppSettings.DaysRoot)
        {
        }
    }
}
