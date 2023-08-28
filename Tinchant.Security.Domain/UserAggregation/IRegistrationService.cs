namespace Tinchant.Security.Domain.UserAggregation
{
    public interface IRegistrationService
    {
        string HashPassword(string password);
    }
}