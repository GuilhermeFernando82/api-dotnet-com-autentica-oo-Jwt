using crud_dotnet.Models;

namespace crud_dotnet.Repository
{
    public interface IuserRepository
    {
        Task<IEnumerable<Usuario>> BuscarUsuarios();
        Task<Usuario> Authentic(string username, string password);
        Task<Usuario> BuscarUsuario(int id);
        void AddUsuario(Usuario usuarios);
        void AtualizaUsuario(Usuario usuarios);
        void DeletaUsuario(Usuario usuarios);
        Task<bool> SaveChangesAsync();
    }
}
