using LMSAutoTesting.RequestModels;
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
        private const string HOST = "https://piter-education.ru:7070";
        private const string REGISTERHOST = HOST + "/register";
        public int ClientRegistration(RegistrationRequestModel registrationRequestModel)
        {

            string json = JsonSerializer.Serialize<RegistrationRequestModel>(registrationRequestModel);

            HttpResponseMessage responseMessage =SendRequest(HttpMethod.Post, REGISTERHOST, jsonContent: json);

            HttpStatusCode actualCode = responseMessage.StatusCode;

            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);

            return id;
        }

        public static HttpResponseMessage SendRequest(HttpMethod httpMethod, string uriString, string token = null, string jsonContent = null)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            if (!string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = httpMethod,
                RequestUri = new System.Uri(uriString)
            };
            if (!string.IsNullOrWhiteSpace(jsonContent))
            {
                message.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            }

            HttpResponseMessage responseMessage = client.Send(message);
            return responseMessage;
        }
    }
}
