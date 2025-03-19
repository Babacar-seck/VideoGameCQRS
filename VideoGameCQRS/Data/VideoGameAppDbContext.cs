using Microsoft.EntityFrameworkCore;
using VideoGameCQRS.Models;

namespace VideoGameCQRS.Data
{
    public class VideoGameAppDbContext : DbContext
    {
        public VideoGameAppDbContext(DbContextOptions<VideoGameAppDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
    }
}
