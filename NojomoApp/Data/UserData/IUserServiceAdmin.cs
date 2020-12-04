using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NojomoApp.Data.UserData
{
    public interface IUserServiceAdmin
    {
        Task<IEnumerable<UserDto>> GetUserServiceAsync();
      
        Task<bool> SaveUserServiceAsync(UserDto user);
        Task<bool> DeleteUserServiceAsync(int id);
        Task<bool> UpdateUserServiceAsync(int id,UserDto user);
        Task<bool> DeleteMultipleUserServiceAsync(IEnumerable<UserDto> users);
        Task<UserDto> GetUserIdServiceAsync(int id);
    }
}
