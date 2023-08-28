namespace Tinchant.Security.Domain.UserAggregation
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<bool> AnyNameAsync(string name);
    }
}
