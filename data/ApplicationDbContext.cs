using Microsoft.EntityFrameworkCore;
using simpleproject.app.Model.Repository;

namespace simpleproject.app.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Publisher> Publishers { get; set; }
    }
}
