
using TestApi.Models;

namespace TestApi.Repositories
{
    public class DayRepository : BaseRepository<Day, int>
    {
        public DayRepository() : base(AppSettings.DaysRoot)
        {
        }
    }
}
