using System;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IDbRepository : IDisposable
    {
        IUserRepository Users { get; }
        IProductRepository Products { get; }
        IRoleRepository Roles { get; }

        int Commit();

        Task<int> CommitAsync();
    }
}
