using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly DatabaseContext _context;

        public IRoleRepository Roles { get; set; }
        public ISupplierRepository Suppliers { get; set; }
        public IPumpAttendantRepository PumpAttendants { get; set; }
        public IProductRepository Products { get; set; }
        public IUserRepository Users { get; set; }
        public DbRepository(DatabaseContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Roles = new RoleRepository(_context);
            Products = new ProductRepository(_context);
            PumpAttendants = new PumpAttendantRepository(_context);
            Suppliers = new PumpAttendantRepository(_context);

        }

        public void Dispose()
        {
            _context.Dispose();
        }

     

        public int Commit()
        {
            return  _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
           return await _context.SaveChangesAsync();
        }

    }
}
