using DecadenceV2_1_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DecadenceV2_1_DAL.UnitOfWork
{
    public class AppDataContext:DbContext
    {
        private DbSet<Filter> Filters { get; set; }
        private DbSet<Label> Labels { get; set; }
        private DbSet<Project> Projects { get; set; }
        private DbSet<User> Users { get; set; }
        private DbSet<WorkItem> WorkItems { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

            Database.EnsureCreated();
            // Cabinets = Set<Cabinet>();
        }
    }
}