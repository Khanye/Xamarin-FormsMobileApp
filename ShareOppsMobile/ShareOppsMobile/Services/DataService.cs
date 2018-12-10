using ShareOppsMobile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareOppsMobile.Helpers;
using ShareOppsMobile.Views;
using Xamarin.Forms;
using Oppotunity = ShareOppsMobile.Models.Oppotunity;
using SavedOppotunities = ShareOppsMobile.Models.SavedOppotunities;
using UserProfile = ShareOppsMobile.Models.UserProfile;

namespace ShareOppsMobile.Services
{
    public class DataService
    {

        private string Url = "https://shareopps.azurewebsites.net/api";

        public async Task<List<Oppotunity>> GeOppotunities()
        {

            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(Url + "/Oppotunities");
            var opps = JsonConvert.DeserializeObject<List<Oppotunity>>(json);

            return opps;


        }


        public async Task<bool> PostOppotunity(Oppotunity oppotunity)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(oppotunity);

            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(Url + "/Oppotunities", content);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }



        public async Task PutOppotunity(int id, Oppotunity oppotunity)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(oppotunity);

            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(Url + id, content);
        }

        public async Task<bool> RegisterUserAsync(string email, string password, string confirmPassword)
        {
            var httpClient = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword

            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(Url + "/Account/Register", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task<string> LoginAsync(string userName, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName), 
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

            var request = new HttpRequestMessage( HttpMethod.Post, " https://shareopps.azurewebsites.net/Token");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);

            var jwt = await response.Content.ReadAsStringAsync();

            JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);
            var accessToken = jwtDynamic.Value<string>("access_token");

            Debug.WriteLine(jwt);
            return accessToken;
            
        }

        public async Task PostUserProfile(UserProfile userProfile)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(userProfile);

            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(Url + "/UserProfiles", content);
        }

        public async Task<bool> PostSaveOppotunity(Oppotunity oppotunity, string AccessToken)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("Bearer",AccessToken);
            var json = JsonConvert.SerializeObject(oppotunity); 
             
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(Url + "/SavedOppotunities", content);

            if (result.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task<List<SavedOppotunities>> GetSavedOppForUserAsync(string accessToken)
        {
             
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer");
            var json = await httpClient.GetStringAsync(Url + "/SavedOppotunities");
            var opps = JsonConvert.DeserializeObject<List<SavedOppotunities>>(json);

            return opps;


        }

        public async Task<List<Oppotunity>> GetByKeywordAsync(string keyword)
        {
            var client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            //    "Bearer", accessToken);

            var json = await client.GetStringAsync(Url + "/Oppotunities/Search/" + keyword);

            var oppotunities = JsonConvert.DeserializeObject<List<Oppotunity>>(json);

            return oppotunities;
        }

    }

}

     
   