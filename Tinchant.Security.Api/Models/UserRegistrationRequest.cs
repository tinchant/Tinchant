using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Api.Models
{
    public class UserRegistrationRequest : IUserRegistration
    {
        public required string Name { get; set; } = string.Empty;

        public required string Password { get; set; } = string.Empty;

        public required string PasswordConfirmation { get; set; } = string.Empty;
    }
}
