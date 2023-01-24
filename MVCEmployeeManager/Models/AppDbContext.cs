using Microsoft.EntityFrameworkCore;

namespace MVCEmployeeManager.Models
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // map to employee model
        public DbSet<Employee> Employees { get;set; }
    }
}
