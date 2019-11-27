using System.Linq;
using System.Threading.Tasks;

namespace Virgo.Backend.Repository.Repository
{
    public interface IGenericMySQLAccessRepository<T>
    {
        IQueryable<T> GetQueryable(string includeProperties = "");
        Task SaveChanges();
        Task SaveChnagesAsync();
        Task Delete();
        Task DeleteRange();
    }
}
