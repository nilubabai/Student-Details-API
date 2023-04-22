using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Details_API.Models
{
    [JsonObject("students")]
    public class Students
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("hobbies")]
        public string[] Hobbies { get; set; }
    }
}