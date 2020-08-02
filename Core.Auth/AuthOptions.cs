using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Auth
{
    public class AuthOptions
    {
        public int Lifetime { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string PublicKeyString { get; set; }
        public string PrivateKeyString { get; set; }
    }
}
