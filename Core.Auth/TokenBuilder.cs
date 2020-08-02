using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Auth
{
    public class TokenBuilder
    {
        private readonly AuthOptions _authOptions;

        public TokenBuilder(AuthOptions authOptions)
        {
            _authOptions = authOptions;
        }

        public string CreateToken(string login, string role, int userId)
        {
            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                issuer: _authOptions.Issuer,
                audience: _authOptions.Audience,
                notBefore: now,
                claims: GetClaims(login, role, userId),
                expires: now.AddMinutes(_authOptions.Lifetime),
                signingCredentials: new SigningCredentials(new KeyBuilder(_authOptions).PrivateKey, SecurityAlgorithms.RsaSha256)
                );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(jwt);

            return tokenString;
        }

        private IEnumerable<Claim> GetClaims(string login, string role, int userId)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role),
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            };

            return claims;
        }
    }
}
