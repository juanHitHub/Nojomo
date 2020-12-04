using System.Threading.Tasks;

namespace NojomoApp.Data.UserData
{
    public interface IUserService
    {
        Task<UserDto> LoginAsync(UserDto user);
        public Task<UserDto> RegisterUserAsync(UserDto user);
        public Task<UserDto> GetUserByAccessTokenAsync(string accessToken);
        public Task<UserDto> RefreshTokenAsync(RefreshRequest refreshRequest);
    }
}
