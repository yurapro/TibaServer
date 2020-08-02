using Core.Auth;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tiba.Data.Repository.Infrastructure;
using Tiba.Domain;
using Tiba.Services.Infractructure;

namespace Tiba.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthOptions _options;
        public AccountService(IUserRepository userRepository, IOptions<AuthOptions> options)
        {
            _userRepository = userRepository;
            _options = options.Value;
        }

        public object LogIn(string login, string password)
        {
            User user = _userRepository.Query(q => q.Email == login && q.Password == password).FirstOrDefault();

            if (user != null)
            {
                TokenBuilder tokenBuilder = new TokenBuilder(_options);
                var token = tokenBuilder.CreateToken(user.Email, user.Role, user.Id);

                var result = new
                {
                    id = user.Id,
                    token = token,
                    username = user.Email
                };

                return result;
            }
            else
                return null;
        }
    }
}
