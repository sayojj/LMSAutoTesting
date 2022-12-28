using System.Text.Json.Serialization;

namespace LMSAutoTesting.RequestModels
{
    public class AuthRequestModel
    {
            [JsonPropertyName("email")]
            public string email { get; set; }

            [JsonPropertyName("password")]
            public string password { get; set; }
    }
}
