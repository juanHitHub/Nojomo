using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using Blazored.LocalStorage;

namespace NojomoApp.Data.UserData
{
    public class UserServiceAdmin: IUserServiceAdmin
    {
        public HttpClient _httpClient { get; }

        public AppSettings _appSettings { get; }

        public ILocalStorageService _localStorageService { get; }

        public UserServiceAdmin(
            HttpClient httpClient,
            IOptions<AppSettings> appSettings,
            ILocalStorageService localStorageService
            )
        {
          
            _appSettings = appSettings.Value;
            _localStorageService = localStorageService;
            httpClient.BaseAddress = new Uri(_appSettings.UserStoresBaseAddress);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlazorServer");

            _httpClient = httpClient;
        }
        public async Task<IEnumerable<UserDto>> GetUserServiceAsync()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "User");

            var token = await _localStorageService.GetItemAsync<string>("accessToken");
            requestMessage.Headers.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonConvert.DeserializeObject<IEnumerable<UserDto>>(responseBody));
            }
            else
                return null;
        }

        public async Task<UserDto> GetUserIdServiceAsync(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "User/" + id);

            var token = await _localStorageService.GetItemAsync<string>("accessToken");
            requestMessage.Headers.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();

                return await Task.FromResult(JsonConvert.DeserializeObject<UserDto>(responseBody));
            }
            else
                return null;
        }


        public async Task<bool> SaveUserServiceAsync(UserDto user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "User");

            var token = await _localStorageService.GetItemAsync<string>("accessToken");
            requestMessage.Headers.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
             = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseBody = await response.Content.ReadAsStringAsync();
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public async Task<bool> DeleteUserServiceAsync(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, "User/" + id);

            var token = await _localStorageService.GetItemAsync<string>("accessToken");
            requestMessage.Headers.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public async Task<bool> DeleteMultipleUserServiceAsync(IEnumerable<UserDto> users)
        {
            foreach (var user in users)
            {
              var  requestMessage = new HttpRequestMessage(HttpMethod.Delete, "User/" + user.Id);

                var token = await _localStorageService.GetItemAsync<string>("accessToken");
                requestMessage.Headers.Authorization
                    = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.SendAsync(requestMessage);
            }
            
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateUserServiceAsync(int id,UserDto user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Put, "User/" + id);

            var token = await _localStorageService.GetItemAsync<string>("accessToken");
            requestMessage.Headers.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);


            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
             = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseBody = await response.Content.ReadAsStringAsync();
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
                       
        }

    }
}
