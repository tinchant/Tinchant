using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Infra.UserAggregation
{
    public class BCryptRegistrationService : IRegistrationService
    {
        public string HashPassword(string password)
            => BCrypt.Net.BCrypt.HashPassword(password);
    }
}
