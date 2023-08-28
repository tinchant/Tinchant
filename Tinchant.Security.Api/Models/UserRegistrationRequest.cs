using System.ComponentModel.DataAnnotations;
using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Api.Models
{
    public class UserRegistrationRequest : IUserRegistration
    {
        [StringLength(255, MinimumLength = 3)]
        public required string Name { get; set; } = string.Empty;

        [StringLength(255, MinimumLength = 6)]
        public required string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public required string PasswordConfirmation { get; set; } = string.Empty;
    }
}
