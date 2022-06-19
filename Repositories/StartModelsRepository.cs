
using System.Collections.Generic;
using TestApi.Models;

namespace TestApi.Repositories
{
    public class StartModelsRepository : BaseRepository<List<User>, int>
    {
        public StartModelsRepository() : base(AppSettings.StartModels)
        {
        }
    }
}
