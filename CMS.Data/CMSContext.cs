using CMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<User> Users { get; set; }
    }
}
