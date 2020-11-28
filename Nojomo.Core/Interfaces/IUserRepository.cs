using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nojomo.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Usuario>> GetUsers();
        Task<Usuario> GetUser(int id);
        Task<bool> InsertUser(Usuario user);
        Task DeleteUser(int id);
        Task UpdateUser(int id,Usuario user);
    }
}
