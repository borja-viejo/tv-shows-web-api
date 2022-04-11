using ApiSeriesCoreOAuth.Models;
using ApiSeriesCoreOAuth.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiSeriesCoreOAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly IPersonajesRepository _personajesRepo;

        public PersonajesController(IPersonajesRepository personajesRepo)
        {
            _personajesRepo = personajesRepo;
        }

        [HttpGet]
        public ActionResult<List<Personaje>> GetPersonajes()
        {
            return _personajesRepo.GetPersonajes();
        }

        [HttpGet("{id}")]
        public ActionResult<Personaje> GetPersonaje(int id)
        {
            return _personajesRepo.GetPersonaje(id);
        }

        [HttpGet("BySerie/{idserie}")]
        public ActionResult<List<Personaje>> GetPersonajeBySerie(int idserie)
        {
            return _personajesRepo.GetPersonajeBySerie(idserie);
        }

        [Authorize]
        [HttpPost]
        public ActionResult<Personaje> AddPersonaje(Personaje pj)
        {
            return _personajesRepo.AddPersonaje(pj);
        }

        [Authorize]
        [HttpPut]
        public ActionResult<Personaje> UpdatePersonaje(Personaje pj)
        {
            return _personajesRepo.UpdatePersonaje(pj);
        }
    }
}
