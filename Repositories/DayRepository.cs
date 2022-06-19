using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
