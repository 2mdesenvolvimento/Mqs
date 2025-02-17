﻿using MQS.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQS.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
        Task<List<User>> SearchByName(string name);
    }
}
