using Microsoft.EntityFrameworkCore;
using SupabaseCrudApi.Models;

namespace SupabaseCrudApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
