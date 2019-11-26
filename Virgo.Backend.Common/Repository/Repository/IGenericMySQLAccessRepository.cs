using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virgo.Backend.Common.Repository.Repository
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
