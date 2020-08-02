using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auth
{
    public class AuthPolicy : AuthorizationHandler<AuthPolicy>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthPolicy requirement)
        {
            if (context.User.Identity.Name.Any(symbol => Char.IsDigit(symbol)))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
