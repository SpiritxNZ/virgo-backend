using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Virgo.Backend.Repository.Context
{
    public class VirgoDbContextFactory : IDesignTimeDbContextFactory<VirgoDbContext>
    {
        public VirgoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VirgoDbContext>();
            optionsBuilder.UseMySQL("server=localhost;port=46985;database=VirgoLocal;user=root;password=my-secret-pw");

            return new VirgoDbContext(optionsBuilder.Options);
        }
    }
}
