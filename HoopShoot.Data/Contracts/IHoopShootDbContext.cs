using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HoopShoot.Data.Contracts
{
    public interface IHoopShootDbContext: IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        DatabaseFacade Database { get; }
    }
}
