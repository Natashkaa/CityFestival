using Microsoft.EntityFrameworkCore;
namespace CoreRegSite
{
    public class CityFestContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-JQDJF79\SQLEXPRESS;initial catalog=CityFest;integrated security=True;MultipleActiveResultSets=True");
        }
    }
}