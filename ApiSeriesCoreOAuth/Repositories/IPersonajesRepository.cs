using ApiSeriesCoreOAuth.Models;
using System.Collections.Generic;

namespace ApiSeriesCoreOAuth.Repositories
{
    public interface IPersonajesRepository
    {
        List<Personaje> GetPersonajes();

        Personaje GetPersonaje(int idpersonaje);

        List<Personaje> GetPersonajeBySerie(int idserie);

        Personaje AddPersonaje(Personaje personaje);

        Personaje UpdatePersonaje(Personaje personaje);

        void DeletePersonaje(int idpersonaje);
    }
}
