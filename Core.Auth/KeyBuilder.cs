using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core.Auth
{
    public class KeyBuilder
    {
        private readonly AuthOptions _authOptions;

        public KeyBuilder(AuthOptions authOptions)
        {
            _authOptions = authOptions;

            PublicKey = GetPublicKey();
            PrivateKey = GetPrivateKey();
        }

        public SecurityKey PublicKey;
        public SecurityKey PrivateKey;

        private SecurityKey GetPrivateKey()
        {
            var key = RSA.Create();
            key.ImportRSAPrivateKey(source: Convert.FromBase64String(_authOptions.PrivateKeyString), bytesRead: out int _);
            return new RsaSecurityKey(key);
        }

        private SecurityKey GetPublicKey()
        {
            var key = RSA.Create();
            key.ImportRSAPublicKey(source: Convert.FromBase64String(_authOptions.PublicKeyString), bytesRead: out int _);
            return new RsaSecurityKey(key);
        }
    }
}
