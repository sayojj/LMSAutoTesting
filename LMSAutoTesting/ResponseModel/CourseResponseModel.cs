using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSAutoTesting.ResponseModel
{
    public class CourseResponseModel
    {
        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("topics")]
        public List<object> topics { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }
    }
}
