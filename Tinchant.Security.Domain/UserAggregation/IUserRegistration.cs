﻿namespace Tinchant.Security.Domain.UserAggregation
{
    public interface IUserRegistration
    {
        string Name { get; }
        string Password { get; }
    }
}