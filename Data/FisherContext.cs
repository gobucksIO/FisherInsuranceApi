using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace FisherInsuranceApi.Data
{
    public class FisherContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        string connection = "User ID=postgres;Password=jugador1;Host=localhost;Port=5432;Database=fisher-insurance;Pooling=true;";
        optionsBuilder.UseNpgsql(connection);
        }

    }
}