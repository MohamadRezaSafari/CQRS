using CQRS_v6.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_v6.Data
{
    public class ApplicationContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
}
