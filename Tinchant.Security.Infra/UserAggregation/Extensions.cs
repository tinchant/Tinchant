using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tinchant.Security.Domain.UserAggregation;

namespace Tinchant.Security.Infra.UserAggregation
{
    public static class Extensions
    {
        public enum RegistrationServiceType
        {
            BCrypt
        }
        public enum RepositoryType
        {
            EF
        }
        public static void AddUserAggregation(this IServiceCollection services, string connectionString, RegistrationServiceType registrationServiceType = RegistrationServiceType.BCrypt, RepositoryType repositoryType = RepositoryType.EF)
        {
            services.AddDbContext<EFUserAggregationUoW>(options => options.UseSqlServer(connectionString));
            switch (registrationServiceType)
            {
                case RegistrationServiceType.BCrypt:
                    services.AddScoped<IRegistrationService, BCryptRegistrationService>();
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (repositoryType)
            {
                case RepositoryType.EF:
                    services.AddScoped<IUserRepository, EFUserRepository>();
                    services.AddScoped<IUserAggregationUoW, EFUserAggregationUoW>();
                    break;
                default:
                    throw new NotImplementedException();
            }            
        }
    }
}
