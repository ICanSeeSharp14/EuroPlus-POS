﻿using Petrol_Pump_Point_Of_Sale_System.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
      
        IEnumerable<User> SearchUsers(string searchValue);

        Task<IEnumerable<dynamic>> GetAllActiveUsers();
   
        Task<User> CheckLoginUser(string username, string password);

       
    }

    
}
