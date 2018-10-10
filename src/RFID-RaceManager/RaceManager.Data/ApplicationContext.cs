using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RaceManager.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
            Database.SetInitializer<ApplicationContext>(null);
            Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        public DbSet<Race> Races { get; set; }

        public DbSet<RaceEvent> RaceEvents { get; set; }

        public DbSet<Pilot> Pilots { get; set; }
    }


    public static class ExtMethods
    {
        public static T ElementAtOrDefault<T>(this List<T> list, int index, T def)
        {
            try
            {
                return list.ElementAt(index);
            }
            catch (Exception)
            {
                return def;
            }
        }

    }
}
