using ApiSeriesCoreOAuth.Models;

namespace ApiSeriesCoreOAuth.Repositories
{
    public interface IUsuariosRepository
    {
        Usuario ExisteUsuario(string email, string password);
    }
}
