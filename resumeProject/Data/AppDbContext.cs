using Microsoft.EntityFrameworkCore;
using resumeProject.Models;

namespace resumeProject.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base (options) 
        {

        }

        public DbSet<Profile> tbl_Profile { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Skill> tbl_Skill { get; set; }
        public DbSet<Language> tbl_Language { get; set; }
        public DbSet<Experince> tbl_Experince { get; set; }
        public DbSet<Projects> tbl_Projects { get; set; }
    }
}
