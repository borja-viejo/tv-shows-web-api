using ApiSeriesCoreOAuth.Models;
using ApiSeriesCoreOAuth.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ApiSeriesCoreOAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosRepository _usuariosRepo;

        public UsuariosController(IUsuariosRepository usuariosRepo)
        {
            _usuariosRepo = usuariosRepo;
        }

        [Authorize]
        [HttpGet]
        [Route("[Action]")]
        public ActionResult<Usuario> PerfilUsuario()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();

            string json = claims.SingleOrDefault(x => x.Type == "UserData").Value;
            //Convertir el json en un Objeto
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(json);

            return usuario;
        }
    }
}
