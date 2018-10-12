﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
      
        IEnumerable<User> SearchUsers(string searchValue);

        Task<IEnumerable<dynamic>> GetAllActiveUsers();

        IEnumerable<dynamic> GetAll(string searchKey = "",  int skip = 1, int take = 25);


        Task<User> CheckLoginUser(string username, string password);

       
    }

    
}
