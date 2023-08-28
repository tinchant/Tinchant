namespace Tinchant.Security.Domain.UserAggregation
{
    public class User
    {
        protected User()
        {
        }

        public User(IUserRegistration userRegistration, IRegistrationService registrationService)
            : this()
        {
            Name = userRegistration.Name;
            PasswordHash = registrationService.HashPassword(userRegistration.Password)!;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

    }

}
