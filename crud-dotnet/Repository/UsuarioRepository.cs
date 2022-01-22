using crud_dotnet.Data;
using crud_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet.Repository
{
    public class UsuarioRepository : IuserRepository
    {
        private readonly UsuarioContext _context;
        public UsuarioRepository(UsuarioContext usuarioContext)
        {
            _context = usuarioContext;
        }
        public void AddUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void AtualizaUsuario(Usuario usuarios)
        {
            _context.Update(usuarios);
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task<Usuario> BuscarUsuario(int id)
        {
            return await _context.Usuario.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void DeletaUsuario(Usuario usuarios)
        {
            _context.Remove(usuarios);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Usuario> Authentic(string username, string password)
        {
            return await _context.Usuario.Where(x => x.Name == username && x.Password == password).FirstOrDefaultAsync();
        }
    }
}
