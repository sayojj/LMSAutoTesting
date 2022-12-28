using System.Text.Json.Serialization;

namespace LMSAutoTesting.RequestModels
{
    public class CourseRequestModel
    {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("description")]
            public string description { get; set; }
    }
}
