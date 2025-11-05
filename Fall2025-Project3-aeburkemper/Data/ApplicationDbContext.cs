using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fall2025_Project3_aeburkemper.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fall2025_Project3_aeburkemper.Models.Actor> Actor { get; set; } = default!;
        public DbSet<Fall2025_Project3_aeburkemper.Models.Movie> Movie { get; set; } = default!;
        public DbSet<Fall2025_Project3_aeburkemper.Models.ActorMovie> ActorMovie { get; set; } = default!;
    }
}
