using Microsoft.EntityFrameworkCore;
using Virgo.Backend.Common.Repository.Model.MySql;

namespace Virgo.Backend.Common.Repository.Context
{
    public class VirgoDbContext : DbContext
    {
        public VirgoDbContext(DbContextOptions<VirgoDbContext> options) : base(options) { }

        public virtual DbSet<AppUser> AppUsers { get; set; }
    }
}
