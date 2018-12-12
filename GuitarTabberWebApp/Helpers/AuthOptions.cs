using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Helpers
{
    public class AuthOptions
    {
        public const string ISSUER = "GuitarTabber";
        public const string AUDIENCE = "GTUser";
        const string KEY = "authentification_security_key!qwe123";
        public const int LIFETIME = 60;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
