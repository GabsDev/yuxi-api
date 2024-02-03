using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.ObjectModel;
using yuxi_demo.Entity;
using yuxi_demo.Interfaces;

namespace yuxi_demo.Context
{
    public class AppDBContext : DbContext, IAppDBContext
    {
        public DbSet<Location> Locations { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost,1433;Database=YuxiApi;User Id=sa;Password=xxxx;trusted_connection=true;Encrypt=false;TrustServerCertificate=true");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => base.SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mockedLocationsList = new List<Location>()
                {
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Bank",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(13,0)

                 },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Bakery",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(12,0)

                },
                  new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Pharmacy,",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(13,0)

                 },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Park",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(12,0)

                },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Barber shop",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(13,0)

                 },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Supermarket,",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(12,0)

                },
                  new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Candy Store",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(13,0)

                 },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Cinema",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(12,0)

                },
                  new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Restaurant",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(13,0)

                 },
                new Location()
                {
                    ID = Guid.NewGuid(),
                    Description= "Mall",
                    CloseHour= new TimeOnly(10,0),
                    OpenHour=new TimeOnly(12,0)

                },
                };
            modelBuilder.Entity<Location>().HasData(mockedLocationsList);
            base.OnModelCreating(modelBuilder);
        }
    }
}
