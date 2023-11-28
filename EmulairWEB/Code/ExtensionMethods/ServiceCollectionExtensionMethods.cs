using Emulair.BusinessLogic;
using Emulair.BusinessLogic.Base;
using Emulair.BusinessLogic.Implementation.Account;
using Emulair.BusinessLogic.Implementation.Games;
using Emulair.Code.Base;
using Emulair.Common;
using Emulair.Common.DTOs;
using Emulair.WebApp.Code.Base;
using System.Security.Claims;

namespace Emulair.WebApp.Code.ExtensionMethods
{
    public static class ServiceCollectionExtensionMethods
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddScoped<ControllerDependencies>();

            return services;
        }

        public static IServiceCollection AddEmulairBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<ServiceDependencies>();
            services.AddScoped<UserAccountService>();
            services.AddScoped<GameService>();
            return services;
        }

        public static IServiceCollection AddEmulairCurrentUser(this IServiceCollection services)
        {
            services.AddScoped(s =>
            {
                var accessor = s.GetService<IHttpContextAccessor>();
                var httpContext = accessor.HttpContext;
                var claims = httpContext.User.Claims;

                var userIdClaim = claims?.FirstOrDefault(c => c.Type == "Id")?.Value;
                var userEmailClaim = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var isParsingSuccessful = Guid.TryParse(userIdClaim, out Guid id);

                var currentUser = new CurrentUserDto
                {
                    Id = id,
                    IsAuthenticated = httpContext.User.Identity.IsAuthenticated,
                    FirstName = httpContext.User.Identity.Name,
                    Email = userEmailClaim
                };
                return currentUser;
            });

            return services;
        }
    }
}
