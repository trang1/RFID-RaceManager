using System.Data.Entity;

namespace RaceManager.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<Race> Races { get; set; }

        public DbSet<RaceEvent> RaceEvents { get; set; }

        public DbSet<Pilot> Pilots { get; set; }
    }
}
