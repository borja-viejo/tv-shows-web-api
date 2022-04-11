using ApiSeriesCoreOAuth.Models;
using ApiSeriesCoreOAuth.Repositories;
using ApiSeriesCoreOAuth.Token;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ApiSeriesCoreOAuth.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsuariosRepository _usuariosRepo;
        private readonly HelperToken _helper;

        public AuthController(IConfiguration configuration,
                              IUsuariosRepository usuariosRepo)
        {
            this._helper = new HelperToken(configuration);
            this._usuariosRepo = usuariosRepo;
        }

        // Necesitamos un punto de entrada (Endpoint) para
        // que el Usuario envie los datos de su validación
        // Los Endpoint AUTH son POST; lo que recibiremos será UserName & Password
        // que hemos incluido con LoginModel
        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            Usuario usuario = this._usuariosRepo.ExisteUsuario(model.UserName,
                                                               model.Password);
            if (usuario != null)
            {
                // Necesitamos crear un Token que llevará información de tipo Issuer,
                // tiempo de duración, credenciales del Usuario, info extra...
                Claim[] claims = new[]
                {
                    new Claim("UserData", JsonConvert.SerializeObject(usuario))
                };

                JwtSecurityToken token = new JwtSecurityToken
                    (
                     issuer: _helper.Issuer,
                     audience: _helper.Audience,
                     claims: claims,
                     expires: DateTime.UtcNow.AddMinutes(10),
                     notBefore: DateTime.UtcNow,
                     signingCredentials:
                        new SigningCredentials(this._helper.GetKeyToken(),
                        SecurityAlgorithms.HmacSha256)
                    );
                // Devolver una respuesta afirmativa con su Token
                return Ok(
                    new { response = new JwtSecurityTokenHandler().WriteToken(token) }
                    );
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
