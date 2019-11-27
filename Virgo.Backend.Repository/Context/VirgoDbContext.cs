using Microsoft.EntityFrameworkCore;
using Virgo.Backend.Repository.Model.MySql;

namespace Virgo.Backend.Repository.Context
{
    public class VirgoDbContext : DbContext
    {
        public VirgoDbContext(DbContextOptions<VirgoDbContext> options) : base(options) { }

        public virtual DbSet<AppUser> AppUsers { get; set; }
    }
}
