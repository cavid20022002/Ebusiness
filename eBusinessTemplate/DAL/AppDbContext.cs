using eBusinessTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace eBusinessTemplate.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
            
        }

        public DbSet<CustomService>CustomServices { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
