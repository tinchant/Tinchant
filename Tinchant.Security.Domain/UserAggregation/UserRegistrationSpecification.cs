﻿using FluentValidation;

namespace Tinchant.Security.Domain.UserAggregation
{
    public class UserRegistrationSpecification : AbstractValidator<IUserRegistration>
    {
        public UserRegistrationSpecification(IUserRepository userRepository)
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(255).MustAsync(async (name, token) => !await userRepository.AnyNameAsync(name));
            RuleFor(x => x.Password).NotEmpty().MinimumLength(6).MaximumLength(255);
            RuleFor(x => x.PasswordConfirmation).Equal(x => x.Password);
        }
    }
}