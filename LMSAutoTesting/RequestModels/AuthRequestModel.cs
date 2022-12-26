using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
