
using APortfolio.DAL.Entitites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APortfolio.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers{ get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Media> Medias { get; set; }

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
