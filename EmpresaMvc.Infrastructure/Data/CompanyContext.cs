using EmpresaMvc.ApplicationCore.Entitys;
using Microsoft.EntityFrameworkCore;

namespace EmpresaMvc.Infrastructure.Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { } 

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Empresa"); //Name of my table

            modelBuilder.Entity<Company>().Property(f => f.Id).ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Company>().HasData(new[]{
              new Company
              {
                  Id = 1,
                  Name = "Laser Fast",
                  Site = "https://loja.laserfast.com.br",
                  NumberEmployees = 250
              },
              new Company
              {
                  Id = 2,
                  Name = "McDonald's",
                  Site = "https://www.mcdonalds.com.br",
                  NumberEmployees = 30000
              },
              new Company
              {
                  Id = 3,
                  Name = "Meta",
                  Site = "https://about.facebook.com/br/meta/",
                  NumberEmployees = 500000
              },
              new Company
              {
                  Id = 4,
                  Name = "Meta",
                  Site = "",
                  NumberEmployees = 500000
              },
              new Company
              {
                  Id = 5,
                  Name = "Tesla",
                  Site = "https://www.tesla.com",
                  NumberEmployees = 323100
              },
              new Company
              {
                  Id = 6,
                  Name = "Apple",
                  Site = "https://www.apple.com/br/",
                  NumberEmployees = 42313
              }}
            );


        }
    }    
}
