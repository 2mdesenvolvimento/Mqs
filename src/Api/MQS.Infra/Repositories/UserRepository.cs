using MQS.Domain.Entity;
using MQS.Domain.Interfaces;
using MQS.Infra.Context;
using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;

namespace MQS.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly MqsDbContext _context;
        public UserRepository(MqsDbContext context) : base(context)
        {
            _context = context;
        }
        public Task<User> GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<User>> SearchByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<User>> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
