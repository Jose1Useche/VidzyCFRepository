using System.Data.Entity;

namespace VidzyCodeFirst
{
    public class VidzyContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
