
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

namespace MVCMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<DaiLy> DaiLys { get; set; } 

         public DbSet<HeThongPhanPhoi> HeThongPhanPhois { get; set; }
    }
}