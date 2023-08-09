using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-654A43A\\SQLEXPRESS;database=CoreBlogApiDb;integrated Security=true;Encrypt=False");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
