using Microsoft.EntityFrameworkCore;
using SeniorDotNetProject.Data.Entities;

namespace SeniorDotNetProject.Data
{
    public class SeniorDotNetProjectContext : DbContext
    {
        public SeniorDotNetProjectContext(DbContextOptions<SeniorDotNetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}