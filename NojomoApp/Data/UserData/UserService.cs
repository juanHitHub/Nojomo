using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NojomoApp.Data.UserData
{
    public class UserService: IUserService
    {
        public Task<IEnumerable<UserDto>> GetUserServiceAsync()
        {
            string urlREST = "https://localhost:44390/api/User";
            var client = new RestClient(urlREST);
            var request = new RestRequest(Method.GET);
            IRestResponse responseApp = null;
            responseApp = client.Get(request);
            return Task.FromResult(Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<UserDto>>(responseApp.Content));
        }

        public Task<UserDto> GetUserIdServiceAsync(int id)
        {
            string urlREST = "https://localhost:44390/api/User/"+id;
            var client = new RestClient(urlREST);
            var request = new RestRequest(Method.GET);
            IRestResponse responseApp = null;
            responseApp = client.Get(request);
            return Task.FromResult(Newtonsoft.Json.JsonConvert.DeserializeObject<UserDto>(responseApp.Content));
        }


        public Task<bool> SaveUserServiceAsync(UserDto user)
        {
            //Eliminar en cuanto se arreglen el diseño de base de datos
            user.Fecharegistro = DateTime.UtcNow;
            user.Permisos = 1;
            user.Status = 1;
            user.Cestas = 1;
            user.Direcciones = 1;
            user.Direccionpredeterminadaid = 1;
            user.Datosfiscales = 1;
            user.Datosfiscalespredeterminadosid = 1;
            user.Ordenes = 1;

            string urlREST = "https://localhost:44390/api/User";
            var client = new RestClient(urlREST);
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(user);
            IRestResponse responseApp = null;
            responseApp = client.Post(request);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteUserServiceAsync(int id)
        {
            string urlREST = "https://localhost:44390/api/User/"+id;
            var client = new RestClient(urlREST);
            var request = new RestRequest(Method.DELETE);
            IRestResponse responseApp = null;
            responseApp = client.Delete(request);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteMultipleUserServiceAsync(IEnumerable<UserDto> users)
        {
            foreach (var user in users)
            {
                string urlREST = "https://localhost:44390/api/User/" + user.Id;
                var client = new RestClient(urlREST);
                var request = new RestRequest(Method.DELETE);
                IRestResponse responseApp = null;
                responseApp = client.Delete(request);
            }
            
            return Task.FromResult(true);
        }

        public Task<bool> UpdateUserServiceAsync(int id,UserDto user)
        {
            string urlREST = "https://localhost:44390/api/User/"+id;
            var client = new RestClient(urlREST);
            var request = new RestRequest(Method.PUT);
            request.AddJsonBody(user);
            IRestResponse responseApp = null;
            responseApp = client.Put(request);
            return Task.FromResult(true);
        }

    }
}
