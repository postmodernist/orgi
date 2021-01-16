using DecadenceV3DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DecadenceV3DAL.UnitOfWork
{
    public class AppDbContext: DbContext
    {
        private DbSet<Filter> Filters { get; set; }
        private DbSet<Label> Labels { get; set; }
        private DbSet<Project> Projects { get; set; }
        private DbSet<User> Users { get; set; }
        private DbSet<WorkItem> WorkItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            Database.EnsureCreated();
            // Cabinets = Set<Cabinet>();
        }
    }
}