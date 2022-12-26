using Gherkin;
using LMSAutoTesting.RequestModels;
using LMSAutoTesting.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LMSAutoTesting.Support
{
    public class WebClient
    {
        public int GetUserId(RegistrationRequestModel model)
        {
            string json = JsonSerializer.Serialize<RegistrationRequestModel>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/register"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            RegistrationResponseModel User = JsonSerializer.Deserialize<RegistrationResponseModel>(responseJson)!;

            return User.id;
        }

        public string Auth(AuthRequestModel model)
        {
            string json = JsonSerializer.Serialize<AuthRequestModel>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/sign-in"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }

        public void SetRole(string token, int id, string role)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Users/{id}/role/{role}"),
            };
            HttpResponseMessage responseMessage = client.Send(message);
        }
        public int GetIdCreatedCourse(string token, CourseRequestModel model)
        {
            string json = JsonSerializer.Serialize<CourseRequestModel>(model);
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:7070/api/Courses"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            CourseResponseModel Course = JsonSerializer.Deserialize<CourseResponseModel>(responseJson)!;

            return Course.id;
        }
    }
}
