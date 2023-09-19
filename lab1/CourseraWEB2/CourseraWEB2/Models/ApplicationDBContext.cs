using Microsoft.EntityFrameworkCore;

namespace CourseraWEB2.Models
{
    public class ApplicationDBContext: DbContext 
    {
        private DbSet<Customer> Cistomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DENCHAN\\DENCHAN;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
