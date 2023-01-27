using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HoopShoot.Data.Contracts
{
    public interface IHoopShootDbContext: IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        DatabaseFacade Database { get; }
    }
}
