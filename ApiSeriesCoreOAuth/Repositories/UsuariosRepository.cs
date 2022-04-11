using ApiSeriesCoreOAuth.Data;
using ApiSeriesCoreOAuth.Models;
using System.Linq;

namespace ApiSeriesCoreOAuth.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly RepositoryContext _context;

        public UsuariosRepository(RepositoryContext context)
        {
            _context = context;
        }

        public Usuario ExisteUsuario(string email, string password)
        {
            return _context.Usuarios.SingleOrDefault
                (u => u.Email == email && u.Password == password);
        }
    }
}
