﻿using MQS.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQS.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);  
        Task Remove(long id);
        Task<T> Get(long id);
        Task<List<T>> Get();
    }
}
