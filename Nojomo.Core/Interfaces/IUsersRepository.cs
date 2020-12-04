using Nojomo.Core.Entities;
using System.Threading.Tasks;

namespace Nojomo.Core.Interfaces
{
    public interface IUsersRepository
    {
        Task<UserWithToken> Login(Usuario user);
        Task<UserWithToken> RegisterUser(Usuario user);
        Task<UserWithToken> RefreshToken(RefreshRequest refreshRequest);
        Task<Usuario> GetUserByAccessToken(string accessToken);
       
    }
}
