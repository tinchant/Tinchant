using Microsoft.EntityFrameworkCore;
using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Infra.UserAggregation
{
    public class EFUserRepository : IUserRepository
    {
        private readonly EFUserAggregationUoW _dbContext;

        public EFUserRepository(IUserAggregationUoW userAggregationUoW)
        {
            this._dbContext = (EFUserAggregationUoW)userAggregationUoW;
        }
        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task<bool> AnyNameAsync(string name)
        {
            return await _dbContext.Users.AnyAsync(u => u.Name == name);
        }
    }
}
