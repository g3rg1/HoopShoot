using Microsoft.EntityFrameworkCore;

namespace HoopShoot.Data.Contracts
{
    public interface IHoopShootDbContext
    {
        DbSet<T> Set<T>() where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
