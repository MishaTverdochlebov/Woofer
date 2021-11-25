using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooferAPI.Config
{
    public class AuthOptions
    {
        public const string ISSUER = "WooferApp";
        public const string AUDIENCE = "Client";
        const string KEY = "Woofkey42!qweqwe";
        public const int LIFETIME = 5;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.Default.GetBytes(KEY));
        }
    }
}
