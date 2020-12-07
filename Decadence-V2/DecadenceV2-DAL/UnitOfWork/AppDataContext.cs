using Microsoft.EntityFrameworkCore;

namespace DecadenceV2_DAL.UnitOfWork
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            Database.EnsureCreated();
            // Cabinets = Set<Cabinet>();
        }
    }
}