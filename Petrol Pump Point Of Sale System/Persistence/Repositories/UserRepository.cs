using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public UserRepository(DatabaseContext context) 
            : base(context)
        {
                
        }


       
        public IEnumerable<User> SearchUsers(string searchValue)
        {
            return DatabaseContext.Users.Where(u => u.Username.Contains(searchValue)).ToList();
        }

        public async Task<IEnumerable<dynamic>> GetAllActiveUsers()
        {
            var activeUsers = await 
                              DatabaseContext.Users
                             .Where(u => u.IsActive)
                             .Join(DatabaseContext.UsersRole,
                              u => u.RoleId, r => r.UserRoleId
                              ,(u, r) => new
                              {
                                Id = u.UserId,
                                u.Username,
                                u.Password,
                                u.Name,
                                Type = u.UserType,
                                Role = r.UserRoleName,
                                r.RoleDescription
                             }).ToListAsync();

            return activeUsers;
        }
        public async Task<User> CheckLoginUser(string username, string password)
        {
            return await 
                DatabaseContext.Users
                .Where(u => u.Username == username &&
                            u.Password == password &&
                            u.IsActive).SingleOrDefaultAsync();         
        }

      
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}
