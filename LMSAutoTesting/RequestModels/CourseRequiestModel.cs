using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSAutoTesting.RequestModels
{
    public class CourseRequiestModel
    {
        public class Root
        {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("description")]
            public string description { get; set; }
        }

    }
}
