using Microsoft.EntityFrameworkCore;
using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Infra.UserAggregation
{
    public class EFUserAggregationUoW : DbContext, IUserAggregationUoW
    {
        public DbSet<User> Users { get; set; }

        public EFUserAggregationUoW(DbContextOptions<EFUserAggregationUoW> options)
            : base(options)
        {
            base.Database.EnsureCreated();
        }

        public async Task CommitChangesAsync()
        {
            await SaveChangesAsync();
        }
    }
}
