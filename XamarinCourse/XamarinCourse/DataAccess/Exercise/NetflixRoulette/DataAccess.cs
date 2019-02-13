using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinCourse.DataAccess.Exercise.NetflixRoulette
{
    public interface DataAccess
    {
        Task<IEnumerable<Movie>> GetByActorAsync(string selector);
        Task<Movie> GetByTitleAsync(string title);
    }
}