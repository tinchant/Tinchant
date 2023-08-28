namespace Tinchant.Security.Domain.UserAggregation
{
    public interface IUserAggregationUoW
    {
        Task CommitChangesAsync();
    }
}
