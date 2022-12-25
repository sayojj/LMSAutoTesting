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
    }
}
