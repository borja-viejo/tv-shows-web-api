using ApiSeriesCoreOAuth.Data;
using ApiSeriesCoreOAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiSeriesCoreOAuth.Repositories
{
    public class PersonajesRepository : IPersonajesRepository
    {
        //https://www.pragimtech.com/blog/blazor/rest-api-repository-pattern/

        private readonly RepositoryContext _context;

        public PersonajesRepository(RepositoryContext context)
        {
            this._context = context;
        }

        public List<Personaje> GetPersonajes()
        {
            return this._context.Personajes.ToList();
        }

        public Personaje GetPersonaje(int idpersonaje)
        {
            return this._context.Personajes
                .FirstOrDefault(p => p.IdPersonaje == idpersonaje);
        }

        public List<Personaje> GetPersonajeBySerie(int idserie)
        {
            return this._context.Personajes
                .Where(p => p.IdSerie == idserie)
                .ToList();
        }

        public Personaje AddPersonaje(Personaje personaje)
        {
            var result = this._context.Personajes.Add(personaje);
            this._context.SaveChanges();

            return result.Entity;
        }

        public Personaje UpdatePersonaje(Personaje personaje)
        {
            var result = this._context.Personajes
                .FirstOrDefault(p => p.IdPersonaje == personaje.IdPersonaje);

            if (result != null)
            {
                //result.Nombre = personaje.Nombre;
                //result.Imagen = personaje.Imagen;
                result.IdSerie = personaje.IdSerie;

                this._context.SaveChanges();

                return result;
            }
            return null;
        }

        public void DeletePersonaje(int idpersonaje)
        {
            var result = this._context.Personajes
                .FirstOrDefault(p => p.IdPersonaje == idpersonaje);

            if (result != null)
            {
                this._context.Personajes.Remove(result);
                this._context.SaveChanges();
            }
        }
    }
}
