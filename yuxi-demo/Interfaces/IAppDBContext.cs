using Microsoft.EntityFrameworkCore;
using yuxi_demo.Entity;

namespace yuxi_demo.Interfaces
{
    public interface IAppDBContext
    {
        DbSet<Location> Locations { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}