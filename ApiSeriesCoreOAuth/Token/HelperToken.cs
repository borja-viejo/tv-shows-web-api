using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;

namespace ApiSeriesCoreOAuth.Token
{
    public class HelperToken
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Secretkey { get; set; }

        public HelperToken(IConfiguration configuration)
        {
            this.Issuer = configuration["ApiAuth:Issuer"];
            this.Audience = configuration["ApiAuth:Audience"];
            this.Secretkey = configuration["ApiAuth:SecretKey"];
        }

        // Crear método para generar una Clave simétrica a partir de nuestro SecretKey
        public SymmetricSecurityKey GetKeyToken()
        {
            byte[] data =
                System.Text.Encoding.UTF8.GetBytes(this.Secretkey);
            return new SymmetricSecurityKey(data);
        }

        // Método para configurar las opciones de seguridad del Token
        // Los métodos de configuración son: Action
        public Action<JwtBearerOptions> GetJwtOptions()
        {
            Action<JwtBearerOptions> jwtoptions =
                new Action<JwtBearerOptions>(options =>
                {
                    options.TokenValidationParameters =
                    new TokenValidationParameters()
                    {
                        ValidateActor = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = this.Issuer,
                        ValidAudience = this.Audience,
                        IssuerSigningKey = this.GetKeyToken()
                    };
                });
            return jwtoptions;
        }

        // Método para validar la Autentificación
        public Action<AuthenticationOptions> GetAuthOptions()
        {
            Action<AuthenticationOptions> authoptions =
                new Action<AuthenticationOptions>(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                });
            return authoptions;
        }
    }
}
